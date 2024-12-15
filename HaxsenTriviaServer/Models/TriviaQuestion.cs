namespace HaxsenTriviaServer.Models
{

    /// <summary>
    /// Represents a trivia question.
    /// </summary>
    public class TriviaQuestion
    {
        /// <summary>
        /// Gets or sets the unique identifier for the trivia question.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the options for the question.
        /// </summary>
        public List<string> incorrect_answers { get; set; }

        /// <summary>
        /// Gets or sets the correct answer for the question.
        /// </summary>
        public string correct_answer { get; set; }
    }

}
