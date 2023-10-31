using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Member
    {
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Please enter your Email !")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Company Name !")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter your City !")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your Country !")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your Password !")]
        public string Password { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}