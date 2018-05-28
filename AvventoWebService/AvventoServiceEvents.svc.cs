using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Timers;
using AvventoWebService.DataContracts;
using AvventoWebService.Helpers;


namespace AvventoWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AvventoServiceCallBack" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AvventoServiceCallBack.svc or AvventoServiceCallBack.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class AvventoServiceEvents : IAvventoServiceEvents
    {
        public System.Timers.Timer timer;
        public IAvventoServiceCallBack callBack;
        private string _inputParam = null;
        AvventoService avventoWebService = new AvventoService();
    

        public  AvventoServiceEvents()
        {
               avventoWebService.Login("JSECCAPI", "P@$$w0rd");
        }


        void OnTimerElapsed(object sender, ElapsedEventArgs e)
        { 
           
            string output = null;
            if (Cache.concurrentDisplayUpdate.Count > 0)
            {
                DisplayUpdate d = Cache.concurrentDisplayUpdate[0];
                output = HelperMethods.Serialize<DisplayUpdate>(d);
            }
            else
            {
                output = "no data";
            }


            callBack.DisplayNotification(string.Format("Response: {0}\t Date: {1}", output, DateTime.Now.Ticks.ToString()));
        }

        public void OnDisplayUpdate(string inputparam)
        {
            _inputParam = inputparam;
            callBack = OperationContext.Current.GetCallbackChannel<IAvventoServiceCallBack>();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimerElapsed;
            timer.Enabled = true;
        }

    }
}
