using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class OrderCancelRejectionMessage
    {
        [DataMember]
        public int ActiveOrderSequenceNumber { get; set; }

        [DataMember]
        public string ReferenceMessage { get; set; }

        [DataMember]

        public string CurrentOrderStatus { get; set; }

        [DataMember]

        public string OrderReference { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}