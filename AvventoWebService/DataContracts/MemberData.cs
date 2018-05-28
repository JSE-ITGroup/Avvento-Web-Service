using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class MemberData
    {
        [DataMember]
        public int MemberId { get; set; }
        [DataMember]
        public int MasterMemberId { get; set; }
        [DataMember]
        public int ClearingMemberId { get; set; }
        [DataMember]
        public string MemberCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int GlobalMarketId { get; set; }
        [DataMember]
        public string SORAccount { get; set; }
        [DataMember]
        public string PlaceOfSettlement { get; set; }
    }
}