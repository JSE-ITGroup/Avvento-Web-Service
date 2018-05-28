using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class IndexHistoricalData
    {
        [DataMember]
        public int IndexDataId { get; set; }
        [DataMember]
        public int IndexId { get; set; }
        [DataMember]
        public DateTime TradeDate { get; set; }
        [DataMember]
        public double IndexValue { get; set; }
        [DataMember]
        public double MarketCapitalization { get; set; }
       

    }
}