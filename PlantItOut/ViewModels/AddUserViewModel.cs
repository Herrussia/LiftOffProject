using System.ComponentModel.DataAnnotations;

namespace PlantItOut.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Must enter a username")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Must enter a password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords must match!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Must Confirm Password")]
        public string VerifyPassword { get; set; }

    }
}