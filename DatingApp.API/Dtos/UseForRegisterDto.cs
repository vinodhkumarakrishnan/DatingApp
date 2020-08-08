using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UseForRegisterDto
    {   [Required]
        public string Username { get; set; }
         [Required]
         [StringLength(8,MinimumLength=4,ErrorMessage="you need to provide a password between 4-8 characters")]
        public string Password{ get; set; }
    }
}