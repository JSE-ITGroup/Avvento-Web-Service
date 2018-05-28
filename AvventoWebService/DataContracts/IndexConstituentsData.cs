using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class IndexConstituentsData
    {
        [DataMember]
        public int IndexInstrumentId { get; set; }
        [DataMember]
        public int IndexId { get; set; }
        [DataMember]
        public int InstrumentId { get; set; }
    }
}