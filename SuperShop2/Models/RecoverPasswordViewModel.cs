using System.ComponentModel.DataAnnotations;

namespace SuperShop2.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
