using System.ComponentModel.DataAnnotations;

namespace MusicStore.ViewModels.User
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}