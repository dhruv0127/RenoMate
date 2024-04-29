using System.ComponentModel.DataAnnotations;

namespace RenoMate.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string UserPassword { get; set; }

    }
}
