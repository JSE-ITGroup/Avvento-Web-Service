using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{

    [DataContract]
    public class LiveMarketPricesData
    {

        [DataMember]
        public double Change { get; set; }

        [DataMember]
        public double Close { get; set; }

        [DataMember]
        public string InstrumentCode { get; set; }

        [DataMember]

        public double High { get; set; }

        [DataMember]

        public double Low { get; set; }

        [DataMember]

        public double MarketCap { get; set; }

        [DataMember]

        public DateTime Time { get; set; }

        [DataMember]

        public double Volume { get; set; }

        [DataMember]
        public double LastTradedPrice { get; set; }

        [DataMember]
        public double LastTradedQuantity { get; set; }

    }
}