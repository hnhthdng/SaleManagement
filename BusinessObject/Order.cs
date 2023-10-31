using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order
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

        public Member Member { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}