using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using AvventoWebService.DataContracts;
using log4net;

namespace AvventoWebService.Helpers
{
    public class LiveFeedServiceHelper
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string endpoint = "";
        private readonly string wsdluri = "";
        private readonly string contract = "";
        private BasicHttpBinding basicHttpBinding;

       public LiveFeedServiceHelper ()
        {
            endpoint = Properties.Settings.Default.AvventoFeedServiceEndPoint;
            wsdluri = Properties.Settings.Default.AvventoFeedServiceWsdl;
            contract = Properties.Settings.Default.AvventoFeedServiceContract;

            basicHttpBinding = new BasicHttpBinding();
            basicHttpBinding.MaxReceivedMessageSize = 2147483647;
            basicHttpBinding.MaxBufferSize = 2147483647;
            basicHttpBinding.MaxBufferPoolSize = 2147483647;
        }
        private DataTable GetDataFromMethod(string Uri, string endpointAddress, BasicHttpBinding basicHttpBinding, string contractname, string methodName, object[] paramArray)
        {

            DataTable dt = null;
            Uri mexAddress = new Uri(Uri);
            MetadataExchangeClientMode mexMode = MetadataExchangeClientMode.HttpGet;
            string contractName = contractname;



            // Get the metadata file from the service.
            MetadataExchangeClient mexClient = new MetadataExchangeClient(mexAddress, mexMode);
            mexClient.ResolveMetadataReferences = true;
            MetadataSet metaSet = mexClient.GetMetadata();


            // Import all contracts and endpoints
            WsdlImporter importer = new WsdlImporter(metaSet);
            Collection<ContractDescription> contracts = importer.ImportAllContracts();
            ServiceEndpointCollection allEndpoints = importer.ImportAllEndpoints();


            // Generate type information for each contract
            ServiceContractGenerator generator = new ServiceContractGenerator();
            var endpointsForContracts = new Dictionary<string, IEnumerable<ServiceEndpoint>>();

            foreach (ContractDescription contract in contracts)
            {
                generator.GenerateServiceContractType(contract);
                // Keep a list of each contract's endpoints
                endpointsForContracts[contract.Name] =
                    allEndpoints.Where(se => se.Contract.Name == contract.Name).ToList();
            }

           

            if (generator.Errors.Count != 0)
                throw new Exception("There were errors during code compilation.");

            // Generate a code file for the contracts 
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("C#");

            // Compile the code file to an in-memory assembly
            // Don't forget to add all WCF-related assemblies as references
            CompilerParameters compilerParameters = new CompilerParameters(
                new string[]
                {
                    "System.dll", "System.ServiceModel.dll",
                    "System.Runtime.Serialization.dll"
                });
            compilerParameters.GenerateInMemory = true;

            CompilerResults results = codeDomProvider.CompileAssemblyFromDom(
                compilerParameters, generator.TargetCompileUnit);

            if (results.Errors.Count > 0)
            {
                throw new Exception("There were errors during generated code compilation");
            }
            else
            {
               

                // Find the proxy type that was generated for the specified contract
                // (identified by a class that implements the contract and ICommunicationbject)
                Type clientProxyType = results.CompiledAssembly.GetTypes()
                    .First(
                        t => t.IsClass &&
                             t.GetInterface(contractName) != null &&
                             t.GetInterface(typeof(ICommunicationObject).Name) != null);

                // Get the first service endpoint for the contract
                ServiceEndpoint se = endpointsForContracts[contractName].First();
                EndpointAddress endPoint = new EndpointAddress(endpointAddress);
                se.Address = endPoint;
                se.Binding = basicHttpBinding;


                // Create an instance of the proxy
                // Pass the endpoint's binding and address as parameters
                // to the ctor
                object instance = results.CompiledAssembly.CreateInstance(
               clientProxyType.Name,
               false,
               System.Reflection.BindingFlags.CreateInstance,
               null,
               new object[] { se.Binding, se.Address },
               CultureInfo.CurrentCulture, null);

          

                try
                {

                    var retVal = (IEnumerable<Object>)instance.GetType().GetMethod(methodName).Invoke(instance, paramArray);


                    if (retVal != null)
                    {
                        dt = HelperMethods.GetDataTableFromObjects(retVal.ToArray());
                        if (dt != null)
                        {
                            dt.Columns.Remove("ExtensionData");

                        }
                        else
                        {

                           log.Warn(string.Format("Wed Feed: Dataset empty for {0}", methodName));
                        }
                    }
                    else
                    {
                        dt = null;
                       
                    }
                }
                catch (Exception exp)
                {
                    // File.WriteAllText();
                    log.Error(string.Format("Error Occured Operation: {0}", methodName), exp);
                }
            }



            return dt;
        }

        public List<LiveMarketPricesData> GetLiveMarketPricesDatas()
        {
            List<LiveMarketPricesData> liveMarketPricesList = new List<LiveMarketPricesData>();

            DataTable dt = GetDataFromMethod(wsdluri, endpoint, basicHttpBinding, contract, "LiveMarketPrices",  null);
            if (dt != null && dt.Rows.Count> 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    LiveMarketPricesData liveMarketPricesData = new LiveMarketPricesData();
                    liveMarketPricesData.Change = Convert.ToDouble(dr["Change"]);
                    liveMarketPricesData.Close = Convert.ToDouble(dr["Close"]);
                    liveMarketPricesData.High = Convert.ToDouble(dr["High"]);
                    liveMarketPricesData.InstrumentCode = dr["Company"].ToString();
                    liveMarketPricesData.Low = Convert.ToDouble(dr["Low"]);
                    liveMarketPricesData.MarketCap = Convert.ToDouble(dr["MarketCap"]);
                    liveMarketPricesData.Time = Convert.ToDateTime(dr["Time"]);
                    liveMarketPricesData.Volume = Convert.ToDouble(dr["Volume"]);
                    liveMarketPricesData.LastTradedPrice = Convert.ToDouble(dr["LastDealPrice"]);
                    liveMarketPricesData.LastTradedQuantity = Convert.ToDouble(dr["LastTradedQuantity"]);
                    liveMarketPricesList.Add(liveMarketPricesData);
                }
            }
            return liveMarketPricesList;
        }
        public List<LiveIndexPricesData> GetLiveIndexPricesDatas()
        {
            List<LiveIndexPricesData>  liveMarketPricesList = new List<LiveIndexPricesData>();
               DataTable dt = GetDataFromMethod(wsdluri, endpoint, basicHttpBinding, contract, "LiveIndexPrices",  null);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    LiveIndexPricesData liveMarketPricesData = new LiveIndexPricesData();

                    liveMarketPricesData.IndexCode = dr["IndexCode"].ToString();
                    liveMarketPricesData.IndexDescription = dr["IndexDescription"].ToString();
                    liveMarketPricesData.IndexPrice = Convert.ToDouble(dr["IndexPrice"]);
                    liveMarketPricesData.OpeningPrice = Convert.ToDouble(dr["OpeningPrice"]);
                    liveMarketPricesData.TotalMarketCap = Convert.ToDouble(dr["TotalMarketCap"]);
                    liveMarketPricesData.TradeDate = Convert.ToDateTime(dr["TradeDate"]);
                    liveMarketPricesList.Add(liveMarketPricesData);
                }
            }
            return liveMarketPricesList;
        }
    }
}