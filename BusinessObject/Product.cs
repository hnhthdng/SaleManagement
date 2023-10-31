using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter your ProductName !")]
        [Display(Name = " Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter your Weight !")]
        public string Weight { get; set; }

        [Required(ErrorMessage = "Please enter your Unit Price !")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Please enter you Units In Stock !")]
        [Display(Name = "Units In Stock")]
        public int UnitsInStock { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}