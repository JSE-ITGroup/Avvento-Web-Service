using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AvventoWebService
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(AvventoWebService.IAvventoServiceCallBack))]
    interface IAvventoServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void OnDisplayUpdate(string response);
    }
}
