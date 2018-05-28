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
    public class PositionData
    {
        [DataMember]
        public int PositionId { get; set; }
        [DataMember]
        public string ClearingMember { get; set; }
        [DataMember]
        public string Member { get; set; }
        [DataMember]
        public string Dealer { get; set; }
        [DataMember]
        public string Principle { get; set; }

        [DataMember]
        public string InstrumentCode { get; set; }
        [DataMember]
        public double StartPosition { get; set; }
        [DataMember]
        public double Bought { get; set; }
        [DataMember]
        public double Sold { get; set; }
        [DataMember]
        public double ClosingPosition { get; set; }
        [DataMember]
        public int PhysicalPosition { get; set; }
        [DataMember]
        public double PhysicalDeliveries { get; set; }
        [DataMember]
        public DateTime PositionDate { get; set; }
        [DataMember]
        public string SiloLocationCode { get; set; }
        [DataMember]
        public string GradeCode { get; set; }
        [DataMember]
        public string CountryOfOriginCode { get; set; }
        [DataMember]
        public string  BaseRateCode { get; set; }
        [DataMember]
        public double InterestSpread { get; set; }
        [DataMember]
        public double Exposure { get; set; }
    }
}