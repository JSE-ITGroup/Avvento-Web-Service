using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class OrderRejectionMessage
    {
        [DataMember]
        public int ErrorNumber { get; set; }
        [DataMember]
        public  string OrderReference { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}