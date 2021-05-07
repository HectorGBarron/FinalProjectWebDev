using System.ComponentModel.DataAnnotations;
using CooperativeFuneralFundInc.Models.DropDownMenu;


namespace CooperativeFuneralFundInc.Models.SupplyRequest
{
    public class SupplyRequest
    {

        public int SupplyRequestId { get; set; }

        public int StatusID { get; set; }
        public Status Status { get; set; }

        public string StatusComments { get; set; }

        [Required(ErrorMessage = "Item selection is required, please verify")]

        public int OrderItemsID { get; set; }
        public OrderItems OrderItems { get; set; }


        [Required(ErrorMessage = "Request origin is required, please verify")]
        public int RequestOriginId { get; set; }
        public RequestOrigin SupplyRequestOrigin { get; set; }

        
        public int RequestTypeID { get; set; }
        public RequestType RequestTypeDescription { get; set; }


        [Required(ErrorMessage = "Client is required, please verify")]
        public int ClientSupplierID { get; set; }
        public ClientSupplier Client { get; set; }

        public int OwnerNameID { get; set; }
        public Owner Owner { get; set; }
        public string CreatedBy { get; set; }
        public string CreateTime { get; set; }

        public string UpdatedBy { get; set; }
        public string UpdatedTime { get; set; }




    }
}