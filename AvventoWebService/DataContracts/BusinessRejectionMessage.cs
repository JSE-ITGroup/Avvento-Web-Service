using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class BusinessRejectionMessage
    {
        [DataMember]
         public int ReferenceSequenceNumber { get; set; }

        [DataMember]
        public int ReferenceMessageType { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}