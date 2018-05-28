using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class IndicesData
    {
        [DataMember]
        public int IndexId { get; set; }

        [DataMember]
        public string IndicesCode { get; set; }

        [DataMember]
        public string IndicesDescription { get; set; }

        [DataMember]
        public string Classification { get; set; }

    }
}