using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class TradeCaptureRejectionMessage
    {
        [DataMember]
        public int ReferenceSequenceNumber { get; set; }

        [DataMember]
        public string ReferenceMessage { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}