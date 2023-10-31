using System.ComponentModel.DataAnnotations;

namespace SaleWeb.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your Email !")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Password !")]
        public string Password { get; set; }
    }
}