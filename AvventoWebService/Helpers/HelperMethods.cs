using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Stt.Derivatives.Api;
using AvventoWebService.DataContracts;
using log4net;


namespace AvventoWebService.Helpers
{
    public static class HelperMethods
    {

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /*public static string ParsePascal(string pascalstr)
        {
            pascalstr = Regex.Replace(pascalstr, @"[^\u001F-\u007F]", string.Empty);
            return pascalstr;
        }
        */

        public static string ParsePascal(char[] delphiString)
        {
            if (delphiString == null)
            {
                return "";
            }
            int stringLength = (int)delphiString[0];
            int minLength = (stringLength < (delphiString.Length - 1)) ? stringLength : delphiString.Length - 1;
            return new string(delphiString, 1, minLength);
        }



        public static string ObjectPropertyToString(object message)
        {
            Type t = message.GetType();
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                sb.Append(pi.Name.ToString() + " = " + pi.GetValue(message, null).ToString() + System.Environment.NewLine);
            }
            return sb.ToString();
        }

        public static void SetObjectProperty(string propertyName, object value, object obj)
        {
            PropertyInfo propertyInfo = obj.GetType().GetProperty(propertyName);
            // make sure object has the property we are after
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(obj, value, null);
            }
        }

        public static DataTable GetDataTableFromObjects(object[] objects)
        {
            if (objects != null && objects.Length > 0)
            {
                Type t = objects[0].GetType();
                DataTable dt = new DataTable(t.Name);
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    dt.Columns.Add(new DataColumn(pi.Name));
                }
                foreach (var o in objects)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dc.ColumnName.ToUpper().Equals("ExtensionData"))
                            continue;
                        dr[dc.ColumnName] = o.GetType().GetProperty(dc.ColumnName).GetValue(o, null);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            return null;
        }
        public static DataTable ToDataTable<T>(IEnumerable<T> collection)
        {

            PropertyInfo[] propertyInfos;
            propertyInfos = typeof(T).GetProperties(BindingFlags.Public |
                                                          BindingFlags.Static);

            DataTable dt = new DataTable();
            Type t = typeof(T);
            PropertyInfo[] pia = t.GetProperties();
            //Create the columns in the DataTable
            foreach (PropertyInfo pi in pia)
            {
                if ((pi.PropertyType.IsGenericType))
                {
                    Type typeOfColumn = pi.PropertyType.GetGenericArguments()[0];

                    if (pi.Name.ToUpper().Equals("ExtensionData"))
                        continue;
                    dt.Columns.Add(pi.Name, typeOfColumn);
                }
                else
                    dt.Columns.Add(pi.Name, pi.PropertyType);
            }
            //Populate the table
            foreach (T item in collection)
            {
                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo pi in pia)
                {
                    dr[pi.Name] = pi.GetValue(item, null);
                }
                dr.EndEdit();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {

            PropertyInfo[] propertyInfos;
            propertyInfos = typeof(T).GetProperties(BindingFlags.Public |
                                                          BindingFlags.Static);

            Type type = typeof(T);
            var properties = type.GetProperties();
            DataTable dataTable = new DataTable();

            if (list == null)
                return dataTable;


            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static T ParseXml<T>(T structure, XElement actionQuery, QueryAction queryAction)
        {
            Type type = typeof(T);
            T obj = default(T);
            var properties = type.GetProperties();


            switch (queryAction)
            {
                case QueryAction.SubmitActiveOrder:
                    {
                        SubmitOrderStructure template = new SubmitOrderStructure();
                        SubmitOrderStructure results = null;
                        var result = actionQuery.Elements("SubmitOrder")
                          .Elements()
                          .ToList();
                        results = GetObject<SubmitOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.SubmitBulkOrder:
                    {

                        SubmitOrderStructure template = new SubmitOrderStructure();
                        SubmitOrderStructure results = null;
                        var result = actionQuery.Elements()
                          .ToList();

                        results = GetObject<SubmitOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);

                        break;
                    }
                case QueryAction.CancelAllOrders:
                    {
                        CancelAllOrdersStructure template = new CancelAllOrdersStructure();
                        CancelAllOrdersStructure results = null;
                        var result = actionQuery.Elements("CancelAllOrders")
                          .Elements()
                          .ToList();
                        results = GetObject<CancelAllOrdersStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.SuspendActiveOrder:
                    {
                        CancelOrSuspendOrderStructure template = new CancelOrSuspendOrderStructure();
                        CancelOrSuspendOrderStructure results = null;
                        var result = actionQuery.Elements("SuspendActiveOrder")
                          .Elements()
                          .ToList();
                        results = GetObject<CancelOrSuspendOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.DeleteActiveOrder:
                    {
                        DeleteOrderStructure template = new DeleteOrderStructure();
                        DeleteOrderStructure results = null;
                        var result = actionQuery.Elements("DeleteActiveOrder")
                          .Elements()
                          .ToList();
                        results = GetObject<DeleteOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.EditSuspendedOrder:
                    {
                        EditSuspendedOrderStructure template = new EditSuspendedOrderStructure();
                        EditSuspendedOrderStructure results = null;
                        var result = actionQuery.Elements("EditSuspendedOrder")
                          .Elements()
                          .ToList();
                        results = GetObject<EditSuspendedOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.ReduceOrderQuantity:
                    {
                        ReduceOrderStructure template = new ReduceOrderStructure();
                        ReduceOrderStructure results = null;
                        var result = actionQuery.Elements("ReduceOrderQuantity")
                          .Elements()
                          .ToList();
                        results = GetObject<ReduceOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.InstrumentSubscription:
                    {
                        List<InstrumentCodeStructure> instrumentCodeStructureList = new List<InstrumentCodeStructure>();

                        InstrumentSubscriptionStructure template = new InstrumentSubscriptionStructure();
                        InstrumentSubscriptionStructure instrumentSubscriptionStructure = null;

                        var action = actionQuery.Elements("InstrumentSubscription")
                          .Elements()
                          .ToList();

                        var _instrumentcode = actionQuery.Elements("InstrumentSubscription").Elements("Instruments")
                         .Elements()
                         .ToList();

                        foreach (var element in _instrumentcode)
                        {
                            InstrumentCodeStructure instrumentCodeStructure = new InstrumentCodeStructure();
                            instrumentCodeStructure.InstrumentCode = element.Value;
                            instrumentCodeStructureList.Add(instrumentCodeStructure);
                        }

                        instrumentSubscriptionStructure = GetObject<InstrumentSubscriptionStructure>(template, action);
                        instrumentSubscriptionStructure.InstrumentCodes = instrumentCodeStructureList;
                        obj = (T)Convert.ChangeType(instrumentSubscriptionStructure, type);
                        break;
                    }
                case QueryAction.IndicesSubscription:
                    {
                        IndicesSubscriptionStructure template = new IndicesSubscriptionStructure();
                        IndicesSubscriptionStructure results = null;
                        var result = actionQuery.Elements("IndicesSubscription")
                          .Elements()
                          .ToList();
                        results = GetObject<IndicesSubscriptionStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.DeleteSuspendedOrder:
                    {

                        break;
                    }
                case QueryAction.ResubmitSuspendedOrder:
                    {
                        ResubmitOrderStructure template = new ResubmitOrderStructure();
                        ResubmitOrderStructure results = null;
                        var result = actionQuery.Elements("ResubmitSuspendedOrder")
                          .Elements()
                          .ToList();
                        results = GetObject<ResubmitOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.EditActiveOrder:
                    {
                        EditActiveOrderStructure template = new EditActiveOrderStructure();
                        EditActiveOrderStructure results = null;
                        var result = actionQuery.Elements("EditActiveOrder")
                          .Elements()
                          .ToList();
                        results = GetObject<EditActiveOrderStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }
                case QueryAction.DataDownload:
                    {

                        DataDownloadStructure template = new DataDownloadStructure();
                        DataDownloadStructure results = null;
                        var result = actionQuery.Elements("DataDownload")
                          .Elements()
                          .ToList();
                        results = GetObject<DataDownloadStructure>(template, result);
                        obj = (T)Convert.ChangeType(results, type);
                        break;
                    }

                default:
                    {
                        break;
                    }


            }

            return obj;


        }



        public static T GetObject<T>(T structure, List<XElement> result)
        {
            if (structure == null) //|| result == null)
            {
                return default(T);
            }

            Type type = structure.GetType();

            foreach (var element in result)
            {

                PropertyInfo prop = type.GetProperty(element.Name.LocalName);
                if (prop != null)
                {
                    prop.SetValue(structure, element.Value.Trim(), null);
                }
            }

            return (T)structure;


        }
        public static T FromXml<T>(String xml)
        {
            T returnedXmlClass = default(T);

            try
            {
                using (TextReader reader = new StringReader(xml))
                {
                    try
                    {
                        returnedXmlClass =
                            (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                    }
                    catch (InvalidOperationException)
                    {
                        // String passed is not XML, simply return defaultXmlClass
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return returnedXmlClass;
        }

        public static byte[] SerializeToByteArray<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return CompressNoLength(CleanInvalidXmlChars(stringwriter.ToString()));
            }
            catch
            {
                throw;
            }
        }

        public static string CleanInvalidXmlChars(string text)
        {
            // From xml spec valid chars:
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]     
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF.
            string regex = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";
            var rslt =Regex.Replace(text, regex, "");
          //  rslt = CleanInvalidXmlChars(rslt, "");

            return rslt;
        }
        private static string CleanInvalidXmlChars(string text,string invalidcharactersfile)
        {
            invalidcharactersfile = "StringsToClean.txt";
            string basedir = System.Web.HttpContext.Current.Server.MapPath("~/bin/Files/CleanData/");
            var filepath = System.IO.Path.Combine(basedir, invalidcharactersfile);
            if (File.Exists(filepath))
            {
                string[] characters = File.ReadAllLines(filepath);
                foreach (string str in characters)
                {
                    text = text.Replace(">" + str.Trim(), ">");
                }
                
            }
            return text;
        }

        public static string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                var xmlstr = stringwriter.ToString().Trim();

               

              //  System.IO.File.WriteAllText();
                xmlstr=  CleanInvalidXmlChars(stringwriter.ToString().Trim());
                // return xmlstr;
                return xmlstr;
            }
            catch (Exception exp)
            {

                throw new FaultException("Serialization Error:" + exp.Message);
            }
        }

        public static bool ValidateSchema(string xmlstring, string xsdPath, out string message)
        {

            if (!File.Exists(xsdPath))
            {
                string msg = string.Format("File: {0} do not exist", xsdPath);
                message = msg;
              log.Warn(msg);
                return true;
            }
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            message = null;
            try
            {
                xml.Schemas.Add(null, xsdPath);
            }
            catch (Exception exp)
            {

                message = exp.Message;
                log.Error("Schema Validation",exp);
                return true;

            }


            try
            {
                xml.Validate(null);
            }
            catch (Exception exp)
            {
                message = exp.Message;
                log.Error("Schema Validation", exp);
                return false;
            }
            return true;
        }

        public static byte[] CompressNoLength(string input)
        {
            byte[] data = Encoding.ASCII.GetBytes(input);

            using (MemoryStream inStream = new MemoryStream())
            {
                using (GZipStream zip = new GZipStream(inStream, CompressionMode.Compress, true))
                {
                    zip.Write(data, 0, data.Length);
                }
                inStream.Position = 0;
                byte[] compressed = new byte[inStream.Length];
                inStream.Read(compressed, 0, compressed.Length);
                return compressed;
            }
        }
    }

}


