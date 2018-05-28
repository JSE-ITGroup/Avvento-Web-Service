using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class ActiveOrderData
    {
        [DataMember]
      
        public int ActiveOrderId { get; set; }

        [DataMember]
      
        public string ClearingMember { get; set; }

      
        public string MemberCode { get; set; }

        [DataMember]
        public string DealerCode { get; set; }

        public string AccountNumber { get; set; }

        [DataMember]
        public string ClientCode { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public long Quantity { get; set; }

        [DataMember]
        public string InstrumentCode { get; set; }

     
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
        public char PrincipleAgency { get; set; }
        [DataMember]
        public DateTime ExpiryDate { get; set; }
        [DataMember]
        public string AdditionalReference { get; set; }
        [DataMember]
        public string CsdAccountNumber { get; set; }
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

    }
}