using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class TripartiteSetupData
    {
        [DataMember]
        public string Member { get; set; }

        [DataMember]
        public string Client { get; set; }

        [DataMember]
        public string ClearingMember { get; set; }

        [DataMember]
        public string TripartiteMember { get; set; }

        [DataMember]
        public string ClientName { get; set; }
    }
}