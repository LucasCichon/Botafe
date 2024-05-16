using System.ComponentModel.DataAnnotations;

namespace BotafeFront.Models
{
    public class EventOwnersForm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
