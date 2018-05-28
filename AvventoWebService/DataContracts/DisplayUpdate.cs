using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Stt.Derivatives.Api;

namespace AvventoWebService.DataContracts
{
    public class DisplayUpdate
    {
        public bool IsAnonymous { get; set; }
        public string InstrumentCode { get; set; }
        public double MidPrice { get; set; }
        public double LastDealPrice { get; set; }
        public string LastDealTime { get; set; }
        public long DealVolume { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public long DaysVolume { get; set; }
        public int LastBidQuantity { get; set; }
        public char LastBidBuySell { get; set; }
        public double LastBidPrice { get; set; }
        public int NumDepth;
        public double OpenInterest { get; set; }
        public double Change { get; set; }
        public string Auction { get; set; }
        public int ContractStatus { get; set; }
        public int OddLot { get; set; }
        public long LastTradedQuantity { get; set; }
        public int IdContractDate { get; set; }
        public int IdSecondaryContractDate { get; set; }
        public int IdStrike { get; set; }
        public int ShardSequenceNumber { get; set; }
        public int StackSequenceNumber { get; set; }
        
        public string LocationCode { get; set; }

        public string GradeCode { get; set; }

        public string CountryOfOrigin { get; set; }

        public string DepthTime { get; set; }
        public double VWAP { get; set; }
        public double ClosingPrice { get; set; }


    }
}