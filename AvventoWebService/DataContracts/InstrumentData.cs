using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class InstrumentData
    {

        public int InstrumentId { get; set; }
        public int TradingSessionId { get; set; }
        public int InstrumentTypeId { get; set; }
        public int GroupId { get; set; }
        public int FutureFeeId { get; set; }
        public int OptionFeeId { get; set; }
        public int DeliveryFeeId { get; set; }
        public string Market { get; set; }
        public byte MarketShard { get; set; }

        public string Instrument { get; set; }
        public string InstrumentClass { get; set; }

        public string ISIN { get; set; }

        public string Description { get; set; }

        public bool Onscreen { get; set; }
        public DateTime MaturityDate { get; set; }
        public int ValuationMethod { get; set; }
        public int NominalDivisor { get; set; }
        public DateTime IssueDate { get; set; }
        public string InflationIndex { get; set; }
        public bool DividendPaid { get; set; }
        public int UnderlyingId { get; set; }
        public bool OptionExerciseIsPercentage { get; set; }
        public double OptionExerciseCost { get; set; }
        public double GroupMargin { get; set; }
        public bool VAT { get; set; }
        public double SettlementMargin { get; set; }
        public bool IsPhysicalSettlement { get; set; }

        public string GroupCode { get; set; }

        public bool TopFourty { get; set; }

        public bool TopOneHundred { get; set; }

        public bool ApplyMTMAfterExpiry { get; set; }

        public bool IsReplicaBond { get; set; }
        public double ReferenceCpiRate { get; set; }
        public double MinimumInitiationFee { get; set; }

        public string FirstTradeReference { get; set; }

        public bool ZeroFeeAutoCloseTrades { get; set; }
        public int IdMarginParameterInstrument { get; set; }

        public string CountryCode { get; set; }

        public string DisplayName { get; set; }
        public int NumberOfDaysInYear { get; set; }
        public int BondFormulaDecimalPlaces { get; set; }
        public double CouponRate { get; set; }

        public string Classification { get; set; }
        public int SettlementDays { get; set; }

        public bool ValidatedAtCSD { get; set; }

        public bool PropTradingAllowed { get; set; }

        public string VettingAgentName { get; set; }

        public string VettingAgentContact { get; set; }
        public double ShareHoldingPercentageLimit { get; set; }

        public string Sector { get; set; }

        public string SecurityType { get; set; }

     
    }
}