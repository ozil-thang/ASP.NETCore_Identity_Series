using System.ComponentModel.DataAnnotations;

namespace IdentitySeries.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}