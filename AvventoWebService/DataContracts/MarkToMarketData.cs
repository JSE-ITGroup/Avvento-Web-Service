using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class MarkToMarketData
    {

        [DataMember]
        public int InstrumentId { get; set; }
        [DataMember]
        public int ContractDateId { get; set; }
        [DataMember]
        public int StrikeId { get; set; }
        [DataMember]
        public string InstrumentCode { get; set; }
        [DataMember]
        public double ClosingPrice { get; set; }
        [DataMember]
        public double ClosingRate { get; set; }
        [DataMember]
        public double OpenInterest { get; set; }
        [DataMember]
        public DateTime TradeDate { get; set; }
        [DataMember]
        public double SpotPrice { get; set; }
        [DataMember]
        public double Volatility { get; set; }

    }
}