using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaxsenTriviaServer.Models
{
    
    /// <summary>
    /// Represents a player's score in the trivia game.
    /// </summary>
    public class Score
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int Points { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }

}
