using System.ComponentModel.DataAnnotations;

namespace MusicStore.ViewModels.User
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}