using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SaleWeb.ViewModels
{
    public class CreateMemberViewModel
    {
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
    }
}