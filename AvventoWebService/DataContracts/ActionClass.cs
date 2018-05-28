using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.ModelBinding;
using AvventoWebService.Helpers;

namespace AvventoWebService
{
    public enum QueryAction
    {
        SubmitActiveOrder = 1,

        CancelAllOrders = 2,
        SuspendActiveOrder = 3,
        DeleteActiveOrder = 4,
        EditSuspendedOrder = 5,
        ReduceOrderQuantity = 6,
        ResubmitSuspendedOrder = 7,
        InstrumentSubscription = 8,
        IndicesSubscription = 9,
        DeleteSuspendedOrder = 10,
        DataDownload = 11,
        EditActiveOrder = 12,
        SubmitBulkOrder =13


    }

    [DataContract]
    public class ActionResponse
    {
        [DataMember]
        public string ResponseCode { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]

        public string Reason { get; set; }

        public override string ToString()
        {
           return HelperMethods.Serialize<ActionResponse>(this);

        }
    }

    [DataContract]
    public class BulkOrderActionResponse
    {
        [DataMember]
        public string ResponseCode { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]

        public string Reason { get; set; }

        [DataMember]

        public string OrderReference { get; set; }

        public override string ToString()
        {
            return HelperMethods.Serialize<BulkOrderActionResponse>(this);

        }
    }

    public class SubmitOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Client Acccount Reference is required.")]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Client Account Reference Number Must be between 6 and 7 characters")]
        public string ClientAccountReference { get; set; }
        

        [Required(AllowEmptyStrings = false, ErrorMessage = "Client Code or Account Number field is Required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = " A Single Character (A or C )  for Client Code or Account Number  must be supplied")]
        public string ClientCodeOrAccountNumber { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "A Dealer Code is required.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "The supplied Dealer Code does not meet the length requirement of three(3) Characters.")]
        public string DealerCode { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]
        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]
        public string BuyOrSell { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "IceBergQuantity Value is required.")]
        [DataType(DataType.Currency,ErrorMessage = "The supplied IceBergQuantity Value does not meet the data type requirement")]
        public string IceBergQuantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Quantity Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Quantity Value does not meet the data type requirement")]
        public string Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Price Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Price Value does not meet the data type requirement")]
        public string Price { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BidType Value is required.")]
        [RegularExpression(@"^[0-9]+$",ErrorMessage = "BidType Value must be numeric")]
        public string BidType { get; set; }

       
        [Required(AllowEmptyStrings = false, ErrorMessage = "A CancelFlag Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied CancelFlag Value does not meet the length requirement of a single numeric Character.")]
        [RegularExpression(@"^[0-9]$", ErrorMessage = "Invalid Cancel Flag Specified")]
        public string CancelFlag { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A OrderReference Value is required.")]
        public string OrderReference { get; set; }

        [DataType(DataType.Date, ErrorMessage = "The supplied Expiry Date Value does not meet the data type requirement.")]
        public string ExpiryDate { get; set; }

      

    }

    public class CancelAllOrdersStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]

        public string BuyOrSell { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]

        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Dealer Code is required.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "The supplied Dealer Code does not meet the length requirement of three(3) Characters.")]

        public string DealerCode { get; set; }

    

    }

    public class CancelOrSuspendOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Active Order ID Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Active Order ID Value must be numeric")]
        public string ActiveOrderId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]
        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Dealer Code is required.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "The supplied Dealer Code does not meet the length requirement of three(3) Characters.")]
        public string DealerCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A User Reference Value is required.")]
        public string UserReference { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]
        public string BuyOrSell { get; set; }
    }

    public class DeleteOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Active Order ID Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Active Order ID Value must be numeric")]
        public string ActiveOrderId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]
        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Dealer Code is required.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "The supplied Dealer Code does not meet the length requirement of three(3) Characters.")]
        public string DealerCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]
        public string BuyOrSell { get; set; }
      

    }

    public class EditSuspendedOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Client Acccount Reference is required.")]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Client Account Reference Number Must be between 6 and 7 characters")]
        public string ClientAccountReference { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Client Code or Account Number field is Required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = " A Single Character (A or C )  for Client Code or Account Number  must be supplied")]
        public string ClientCodeOrAccountNumber { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "An Active Order ID Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Active Order ID Value must be numeric")]
        public string ActiveOrderId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]
        public string BuyOrSell { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Price Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Price Value does not meet the data type requirement")]
        public string Price { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Quantity Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Quantity Value does not meet the data type requirement")]
        public string Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Reference Value is required.")]
        public string Reference { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]
        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Dealer Code is required.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "The supplied Dealer Code does not meet the length requirement of three(3) Characters.")]
        public string DealerCode { get; set; }
       

    }

    public class ReduceOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "An Active Order ID Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Active Order ID Value must be numeric")]
        public string ActiveOrderId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]
        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]

        public string BuyOrSell { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Quantity Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Quantity Value does not meet the data type requirement")]

        public string Quantity { get; set; }

    

    }

    public class ResubmitOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "An Active Order ID Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Active Order ID Value must be numeric")]
        public string ActiveOrderId { get; set; }

      

    }

    public class InstrumentCodeStructure
    {
        public string InstrumentCode { get; set; }
       
    }

    public class InstrumentSubscriptionStructure

    {
        public List<InstrumentCodeStructure> InstrumentCodes { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "An Instrument Subsription Action is required(Subsribe|Unsubscribe).")]
        public string Action { get; set; }
     
      
    }

    public class SubmitBulkOrderStructure
    {
       public  List<SubmitOrderStructure> OrdersList { get; set; }
    }

    public class IndicesSubscriptionStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "An Indices Subsription Action is required(Subsribe|Unsubscribe).")]
        public string Action { get; set; }
    }


    public class EditActiveOrderStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "An Active Order ID Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Active Order ID Value must be numeric")]
        public string ActiveOrderId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Instrument Code is required.")]
        public string InstrumentCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Client Acccount Reference is required.")]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Client Account Reference Number Must be between 6 and 7 characters")]
        public string ClientAccountReference { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Client Code or Account Number field is Required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = " A Single Character (A or C )  for Client Code or Account Number  must be supplied")]
        public string ClientCodeOrAccountNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Dealer Code is required.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "The supplied Dealer Code does not meet the length requirement of three(3) Characters.")]
        public string DealerCode { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "A Member Code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The supplied Member Code does not meet the length requirement of 4 Characters.")]
        public string MemberCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A BuyOrSell Value is required.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "The supplied BuyOrSell Value does not meet the length requirement of a single Character.")]
        public string BuyOrSell { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Quantity Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Quantity Value does not meet the data type requirement")]
        public string Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Price Value is required.")]
        [DataType(DataType.Currency, ErrorMessage = "The supplied Price Value does not meet the data type requirement")]
        public string Price { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "An OrderReference Value is required.")]
        public string OrderReferenceNumber { get; set; }

        public string AdditionalOrderReferenceNumber { get; set; }
    }

   

    public class DataDownloadStructure
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "A Data Type Value is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "The Date Type Value must be numeric")]
        public string DataType { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date, ErrorMessage = "A Valid StartDate must be specified.")]
        public string StartDate { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date, ErrorMessage = "The Valid End Date must be specified.")]
        public string EndDate { get; set; }

        // public string RecordStartSequence { get; set; }



    }


}