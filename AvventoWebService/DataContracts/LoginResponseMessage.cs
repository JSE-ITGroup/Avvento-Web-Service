using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class LoginResponseMessage
    {
        [DataMember]
        public string TodayDate { set; get; }

        [DataMember]
        public string CountryCode { set; get; }

        [DataMember]
        public string PreviousBusinessDay { set; get; }

        [DataMember]

        public int NumberofUnqiueMembers { set; get; }

        [DataMember]

        public bool IsSuccessful { get; set; }

        [DataMember]

        public string Text { get; set; }

        /* [DataMember]
         public PairMemberCodeWithUniqueNumber PairMemberCodesWithUniqueNumber { set; get; } */

        [DataMember]
        public string MemberCode { get; set; }

        [DataMember]
        public string UniqueMemberNumber { get; set; }
    }

    [DataContract]
    public class PairMemberCodeWithUniqueNumber
    {
        [DataMember]
        public string MemberCode { get; set; }

        [DataMember]
        public string UniqueMemberNumber { get; set; }
        
    }
}