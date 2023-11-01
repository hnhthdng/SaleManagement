using System.ComponentModel.DataAnnotations;

namespace SaleWeb.ViewModels
{
    public class CreateOrderViewModel
    {
        public int OrderId { get; set; }

        public int MemberId { get; set; }

        [Required(ErrorMessage = "Please enter your Order Time !")]
        [Display(Name = " Order Time")]
        public DateTime OrderTime { get; set; }

        [Display(Name = " Required Time")]
        public DateTime RequiredTime { get; set; }

        [Display(Name = " Shipped Time")]
        public DateTime ShippedTime { get; set; }

        public decimal? Freight { get; set; }
    }
}