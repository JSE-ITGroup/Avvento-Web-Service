using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class ExchangeAnnouncementMessage
    {
        [DataMember]
        public int ErrorNumer { get; set; }

        [DataMember]
        public bool IsInformationIndicator { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}