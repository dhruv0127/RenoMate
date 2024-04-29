using System.ComponentModel.DataAnnotations;

namespace RenoMate.Models
{
    public class UserViewModel
    {
        public string? UserName { get; set; }

        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string UserPassword { get; set; }
        public int UserPhone { get; set; }

        public string UserAddress { get; set; }
    }
}
