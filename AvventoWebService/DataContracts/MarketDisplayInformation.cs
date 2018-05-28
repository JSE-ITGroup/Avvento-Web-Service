using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract,Serializable]
    public class MarketDisplayInformation
    {
      //  [DataMember]
     //   public string CallOrPut { get; set; }
        [DataMember]
        public DateTime FirstExpiryDate { get; set; }
        [DataMember]
        public string IdentifierPrefix { get; set; }
        [DataMember]
        public string FirstInstrumentContractName { get; set; }

        [DataMember]
        public string FirstInstrumentCode { get; set; }
        [DataMember]
        public bool IsDeltaOption { get; set; }
        [DataMember]
        public DateTime SecondaryExpiryDate { get; set; }

        [DataMember]
        public string SecondaryInstrumentContractName { get; set; }

        [DataMember]
        public string SecondaryInstrumentCode { get; set; }

        [DataMember]
        public double Strike { get; set; }

        [DataMember]
        public double OpeningPrice { get; set; }
        [DataMember]
        public int InstrumentId { get; set; }
    }
}