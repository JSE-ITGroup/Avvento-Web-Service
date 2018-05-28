using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class ContractsDateData
    {
        [DataMember]
        public int InstrumentId { get; set; }
        [DataMember]
        public int ContractDateId { get; set; }

        [DataMember]
        public int TradingSessionId { get; set; }

        [DataMember]
        public DateTime ExpiryDate { get; set; }
        [DataMember]
        public DateTime ValuationDate { get; set; }

        [DataMember]
        public double Nominal { get; set; }

        [DataMember]
        public double StrikeInterval { get; set; }

        [DataMember]
        public double StrikeIntervalOffScreen { get; set; }

        [DataMember]
        public double Spread { get; set; }

        [DataMember]
        public int LotSize { get; set; }

        [DataMember]
        public int OptionLotSize { get; set; }

        [DataMember]
        public byte MaxDepth { get; set; }

        [DataMember]
        public char PriceOrRate { get; set; }

        [DataMember]
        public double MaxChange { get; set; }

        [DataMember]
        public double MaxDayMove { get; set; }

        [DataMember]
        public double MaxSpreadDifferential { get; set; }
        [DataMember]
        public bool AONAllowedOnSpotSiloCertificate { get; set; }
        [DataMember]
        public bool OptionsAllowed { get; set; }
        [DataMember]
        public bool DeltasAllowed { get; set; }
        [DataMember]
        public bool SpreadsAllowed { get; set; }
        [DataMember]
        public double InitialMargin { get; set; }
        [DataMember]
        public int QuoteFormatDecimalPlaces { get; set; }
        [DataMember]
        public int PriceFormatDecimalPlaces { get; set; }
        [DataMember]
        public int OptionPremiumFormatDecimalPlaces { get; set; }
        [DataMember]
        public short PriceMultiplier { get; set; }
        [DataMember]
        public DateTime ClearDate { get; set; }
        [DataMember]
        public double VSR { get; set; }
        [DataMember]
        public double RPVE { get; set; }
        [DataMember]
        public int VolatilityRoundPlaces { get; set; }
        [DataMember]
       
        public bool OptionsTradableOnScreen { get; set; }
        [DataMember]
        public bool OptionsTradableReportOnly { get; set; }
        [DataMember]
        public bool FuturesTradableOnScreen { get; set; }
        [DataMember]
        public bool FuturesTradableReportOnly { get; set; }
        [DataMember]
        public double PriceInterval { get; set; }
        [DataMember]
        public int MinValidBidVolumeOnScreen { get; set; }
        [DataMember]
        public int MinValidBidVolumeOffScreen { get; set; }
        [DataMember]
        public int MinValidBidVolumeOnScreenOption { get; set; }
        [DataMember]
        public int MinValidBidVolumeOffScreenOption { get; set; }
        [DataMember]
        public bool AONAllowed { get; set; }
        [DataMember]
        
        public bool AtBestAllowed { get; set; }
        [DataMember]
        public bool StopOrderAllowed { get; set; }
        [DataMember]
        public bool IceBergAllowed { get; set; }
        [DataMember]
        public bool HoldOverAllowed { get; set; }
        [DataMember]
        public bool AtCloseAllowed { get; set; }
        [DataMember]
        public bool IsFutureAnonymous { get; set; }
        [DataMember]
        public bool IsOptionAnonymous { get; set; }
        [DataMember]
        public bool IsSiloAuctionBidAnonymous { get; set; }
        [DataMember]
        public double SiloAuctionPriceInterval { get; set; }
        [DataMember]
        public double BasisPointValue { get; set; }
        [DataMember]
        public bool RFQAllowed { get; set; }
        [DataMember]
        public int QuantityTickSize { get; set; }
        [DataMember]
        public double MaxGap { get; set; }
        [DataMember]
        public long MinAONQty { get; set; }
    
    }
}