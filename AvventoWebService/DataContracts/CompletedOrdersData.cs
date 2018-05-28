using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class CompletedOrdersData
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public string InTime { get; set; }
        [DataMember]
        public string ClearingMember { get; set; }
        [DataMember]
        public string Member { get; set; }
        [DataMember]
        public string Dealer { get; set; }
        [DataMember]
        public string ClientCode { get; set; }

        public string AccountNumber { get; set; }

        [DataMember]
        public string BuyOrSell { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public long Quantity { get; set; }
        [DataMember]
        public string InstrumentCode  {get;set;}
        [DataMember]
        public double Rate { get; set; }
        [DataMember]
        public string OrderReference { get; set; }
        [DataMember]
        public int ExchangeSuffix { get; set; }
        [DataMember]
        public string SubAccount { get; set; }
        [DataMember]
        public long OriginalQuantity { get; set; }
        [DataMember]
        public double DealtRate { get; set; }
        [DataMember]
        public double DealtPrice { get; set; }
        [DataMember]
        public double Consideration { get; set; }
        [DataMember]
        public string SAFReference { get; set; }
        [DataMember]
        public double CarryRate { get; set; }
        [DataMember]
        public string AdditionalUserReference { get; set; }
        [DataMember]
        public DateTime SettlementDate { get; set; }

        [DataMember]
        public DateTime TradeDate { get;set; }
       
        [DataMember]
        public string TradeTime { get; set; }
        [DataMember]
        public string TradeLeg { get; set; }
        [DataMember]
        public string MatchReference { get; set; }
        [DataMember]
        public string EqualOppositeUnex { get; set; }
        [DataMember]
        public string IDBUnex { get; set; }
        [DataMember]
        public DateTime MatchDate { get; set; }
        [DataMember]
        public string MatchTime { get; set; }
        [DataMember]
        public string Counterparty { get; set; }
        public double Price { get; set; }
        [DataMember]
        public string BDAAccountNumber { get; set; }
        [DataMember]
        public bool Script { get; set; }
        [DataMember]
        public bool Cancelled { get; set; }
        [DataMember]
        public string Origin { get; set; }
        [DataMember]
        public string Reason { get; set; }
        [DataMember]
        public string PrincipleAgency { get; set; }
        [DataMember]
        public double SpotPrice { get; set; }
        [DataMember]
        public bool Hitter { get; set; }
        [DataMember]
        public string BookingFeeFlag { get; set; }
        [DataMember]
        public double Delta { get; set; }
        [DataMember]
        public double CleanPrice { get; set; }
        [DataMember]
        public double AccruedInterest { get; set; }
        [DataMember]
        public int SpotContractId { get; set; }
        [DataMember]
        public int SiloReceiptNumber { get; set; }
        [DataMember]
        public string SiloLocationCode { get; set; }
        [DataMember]
        public string GradeCode { get; set; }
        [DataMember]
        public string CountryOfOriginCode { get; set; }
        [DataMember]
        public string BaseRateCode { get; set; }
        [DataMember]
        public double InterestSpread { get; set; }
        [DataMember]
        public int ActiveOrderFilledId { get; set; }

    }
}