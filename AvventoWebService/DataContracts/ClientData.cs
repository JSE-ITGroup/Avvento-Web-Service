using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class ClientData
    {
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int MasterClientId { get; set; }
        [DataMember]
        public int MemberId { get; set; }
        [DataMember]
        public string ClientCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool Verified { get; set; }
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public int MultiplicationFactor { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public DateTime LastDateTraded { get; set; }
        [DataMember]
        public bool IsProfessional { get; set; }
        [DataMember]
        public bool IsShariah { get; set; }
        [DataMember]
        public bool AllowClientSubAccounts { get; set; }
        [DataMember]
        public string PlaceOfSettlement { get; set; }
    }
}