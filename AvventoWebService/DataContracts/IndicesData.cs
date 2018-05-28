using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class IndicesDataClass
    {
        
        [DataMember]
         public int IndexId { get; set; }
        [DataMember]
        public double OpeningPrice { get; set; }

        [DataMember]
        public double IndexPrice { get; set; }

        [DataMember]
        public string UpdateTime { get; set; }
        [DataMember]
        public DateTime UpdateDate { get; set; }
        [DataMember]
        public double MarketCapitalization { get; set; }
    }
}