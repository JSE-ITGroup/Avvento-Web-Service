using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class LiveIndexPricesData
    {
        [DataMember]
        public string IndexCode { get; set; }

        [DataMember]
        public string IndexDescription { get; set; }


        [DataMember]
        public double IndexPrice { get; set; }


        [DataMember]
        public double OpeningPrice { get; set; }


        [DataMember]
        public double TotalMarketCap { get; set; }


        [DataMember]
        public DateTime TradeDate { get; set; }

   
    }
}