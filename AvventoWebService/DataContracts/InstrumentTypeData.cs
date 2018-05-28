using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class InstrumentTypeData
    {
        [DataMember]
        public int InstrumentTypeId { get; set; }
        [DataMember]
        public int TradingSessionId { get; set; }
        [DataMember]
        public int InstrumentTypeNumber { get; set; }
        [DataMember]
        public string IdentifierPrefix { get; set; }
        [DataMember]
      
        public string InstrumentTypeCode { get; set; }

        [DataMember]
        public string InstrumentTypeName { get; set; }
     
    }
}