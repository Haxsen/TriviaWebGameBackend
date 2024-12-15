using HaxsenTriviaServer.Models;

namespace HaxsenTriviaServer.Services
{
    /// <summary>
    /// Service interface for fetching trivia questions.
    /// </summary>
    public interface ITriviaService
    {
        /// <summary>
        /// Fetches trivia questions from the API.
        /// </summary>
        /// <param name="amount">The number of trivia questions to fetch.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the trivia questions in JSON format.</returns>
        Task<List<TriviaQuestion>> GetTriviaQuestionsAsync();
    }

}
