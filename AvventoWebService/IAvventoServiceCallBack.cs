using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AvventoWebService
{
    public interface IAvventoServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void DisplayNotification(string response);
    }
}
