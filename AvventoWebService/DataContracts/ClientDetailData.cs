using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AvventoWebService.DataContracts
{
    [DataContract]
    public class ClientDetailData
    {
        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int ClientMasterId { get; set; }

        [DataMember]
        public int MemberId { get; set; }

        [DataMember]
        public string MemberCode { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string ClientCode { get; set; }

        [DataMember]

        public string NumberId { get; set; }

        [DataMember]

        public string PassportNumber { get; set; }

        [DataMember]

        public string VatRegistration { get; set; }

        [DataMember]

        public string ClientName { get; set; }
        [DataMember]

        public string SecondName { get; set; }

        [DataMember]
        public int ClientGlobalMarketId { get; set; }

        [DataMember]

        public string ComplianceOfficer { get; set; }

        [DataMember]

        public bool DiscretionaryManaged { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        public string ClientsBankAccountNumber { get; set; }

        [DataMember]
        public int Multiplication_Factor { get; set; }

        [DataMember]

        public string SwiftCode { get; set; }

        [DataMember]

        public string RegistrationNumber { get; set; }

        [DataMember]

        public string IncomeTaxNumber { get; set; }

        [DataMember]

        public bool IsUpdate { get; set; }

        [DataMember]

        public bool IsIndividual { get; set; }

        [DataMember]

        public string ElectronicAccountNumber { get; set; }

        [DataMember]

        public bool IsElectronic { get; set; }
        [DataMember]

        public bool Proof_Of_Residence_Supplied { get; set; }
        [DataMember]

        public bool ProofOfRegistrationSupplied { get; set; }

        [DataMember]
        public DateTime DateClientLoaded { get; set; }

        [DataMember]
        public DateTime DateClientVerified { get; set; }

        [DataMember]

        public bool IsStaffAccount { get; set; }

        [DataMember]

        public bool CanClearingMemberChangeMarginMultiplier { get; set; }

        [DataMember]

        public bool IsBeneficialInterestAccount { get; set; }

        [DataMember]

        public string StrateClientCode { get; set; }

        [DataMember]

        public string SettlementAgentStrateCode { get; set; }


        [DataMember]

        public string FundsAccountNumber { get; set; }

        [DataMember]

        public string ScripAccountNumber { get; set; }

        [DataMember]

        public string FundsAccountBranchCode { get; set; }

        [DataMember]

        public string ScripAccountBranchCode { get; set; }

        [DataMember]

        public string ClientType { get; set; }

        [DataMember]

        public string IndustryCode { get; set; }

        [DataMember]

        public string TradingRole { get; set; }

        [DataMember]

        public string BDAAccountNumber { get; set; }

        [DataMember]

        public bool IsProfessional { get; set; }

        [DataMember]

        public bool IsShariah { get; set; }
   

    }
}