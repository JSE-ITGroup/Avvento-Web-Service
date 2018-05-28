using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class DealerData
    {
        [DataMember]
        public int DealerId { get; set; }
        [DataMember]
        public bool IsMarketMaker { get; set; }
        [DataMember]
        public int MemberId { get; set; }
        [DataMember]
        public string IDCode { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string TelephoneNumber { get; set; }
        [DataMember]
        public string FaxNumber { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
    }
}