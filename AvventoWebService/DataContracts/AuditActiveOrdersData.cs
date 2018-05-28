using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web;
using Stt.Derivatives.Api;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class AuditActiveOrdersData
    {
        [DataMember]
        public int IdOrder { get; set; }
        [DataMember]
        public string ClearingMember { get; set; }
        [DataMember]
        public string Member { get; set; }
        [DataMember]
        public string Dealer { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string Principle { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public long Quantity { get; set; }
        [DataMember]
        public string InstrumentCode {get; set; }
        [DataMember]
        public double Quote { get; set; }
        [DataMember]
        public string BuyOrSell { get; set; }
        [DataMember]
        public string InTime { get; set; }
        [DataMember]
        public string OrderReference { get; set; }
        [DataMember]
        public string SubAccount { get; set; }
        [DataMember]
        public long IcebergQuantity { get; set; }
        [DataMember]
        public string PrincipleAgency { get; set; }
        [DataMember]
        public DateTime HoldoverDate { get; set; }
        [DataMember]
        public string AdditionalReference { get; set; }
        [DataMember]
        public string BDAAccountNumber { get; set; }
        [DataMember]
        public int SiloReceiptNumber { get; set; }
        [DataMember]
        public string SiloLocationCode { get; set; }
        [DataMember]
        public string GradeCode { get; set; }
        [DataMember]
        public string CountryOfOriginCode { get; set; }
        [DataMember]
        public bool MustFill { get; set; }
        [DataMember]
        public int BidType { get; set; }
        [DataMember]
        public string ActionTaken { get; set; }
        [DataMember]
        public string ActionTime { get; set; }

    }
}