using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvventoWebService.DataContracts
{
    public class SharesInIssueData
    {
        public int IdSharesInIssue { get; set; }
        public int IdInstrument { get; set; }
        public double Balance { get; set; }
        public double CurrentValue { get; set; }
        public double PreviousBalance { get; set; }
        public double PreviousCurrentValue { get; set; }
   
    }
}