using System.ComponentModel.DataAnnotations;

namespace HaxsenTriviaServer.Models
{

    /// <summary>
    /// Represents a user in the trivia game system.
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public bool IsGuest { get; set; }
    }

}
