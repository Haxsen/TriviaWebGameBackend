using Refit;
using System.Threading.Tasks;
using System.Collections.Generic;
using HaxsenTriviaServer.Models;

namespace HaxsenTriviaServer.Services
{
    
    /// <summary>
    /// Represents a client to interact with the OpenTdb API.
    /// </summary>
    public interface IOpenTdbClient
    {
        /// <summary>
        /// Gets a list of trivia questions.
        /// </summary>
        /// <returns>A list of trivia questions.</returns>
        [Get("/api.php?amount=10&difficulty=easy&type=multiple")]
        Task<ApiResponse<ApiResult>> GetTriviaQuestions();
    }

}
