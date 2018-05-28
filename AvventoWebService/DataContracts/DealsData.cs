using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web;


namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class DealsData
    {
        [DataMember]
        public int DealId { get; set; }
        [DataMember]
        public string TradeTime { get; set; }
        [DataMember]
        public string ClearingMemberCode { get; set; }
        [DataMember]
        public string MemberCode { get; set; }
        [DataMember]
        public string DealerCode { get; set; }
        [DataMember]
        public string PrincipalCode { get; set; }
        [DataMember]
        public string BuyOrSell { get; set; }
        [DataMember]
        public string DealType { get; set; }
        [DataMember]
        public long Quantity { get; set; }

        [DataMember]
        private string InstrumentCode { get; set; }
    
        [DataMember]
        public double Rate { get; set; }
        [DataMember]
        public string UserReference { get; set; }
        [DataMember]
        public ushort ExchangeSuffix { get; set; }

        [DataMember]
        public string SubAccount { get; set; }
        [DataMember]
        public string JSEReference { get; set; }
        [DataMember]
        public double DealPrice { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        public string CounterPartyAccountNumber { get; set; }
        [DataMember]
        public double Consideration { get; set; }
        [DataMember]
        public DateTime TradeDate { get; set; }
        [DataMember]
        public string BookingFeeFlag { get; set; }
        [DataMember]
        public string Reason { get; set; }
        [DataMember]
        public string Counterparty { get; set; }
        [DataMember]
        public double MarkToMarket { get; set; }
        [DataMember]
        public double Fee { get; set; }
        [DataMember]
        public string EnteredTime { get; set; }
        [DataMember]
        public bool IsGuaranteed { get; set; }
        [DataMember]
        public string AllocationTime { get; set; }
        [DataMember]
        public string AdditionalUserReference { get; set; }
        [DataMember]
        public bool SelfTraded { get; set; }
        [DataMember]
        public string PrincipleAgency { get; set; }
        [DataMember]
        public double Delta { get; set; }
        [DataMember]
        public double MakerQuantity { get; set; }
        [DataMember]
        public double ReportOnlyQuantity { get; set; }
        [DataMember]
        public long OriginalQuantity { get; set; }
        [DataMember]
        public int SiloReceiptNumber { get; set; }
        [DataMember]
        public bool PartialFill { get; set; }
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

    }
}