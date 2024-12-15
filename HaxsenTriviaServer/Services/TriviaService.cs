using HaxsenTriviaServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HaxsenTriviaServer.Services
{
    /// <summary>
    /// Implementation of ITriviaService to interact with OpenTdbClient.
    /// </summary>
    public class TriviaService : ITriviaService
    {
        private readonly IOpenTdbClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="TriviaService"/> class.
        /// </summary>
        /// <param name="client">The OpenTdb client.</param>
        public TriviaService(IOpenTdbClient client)
        {
            _client = client;
        }

        /// <inheritdoc />
        public async Task<List<TriviaQuestion>> GetTriviaQuestionsAsync()
        {
            var response = await _client.GetTriviaQuestions();

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"response results: {string.Join(", ", response.Content.results)}");
                return response.Content.results.Select(q => new TriviaQuestion
                {
                    Question = q.Question,
                    incorrect_answers = q.incorrect_answers,
                    correct_answer = q.correct_answer
                }).ToList();
            }

            throw new HttpRequestException("Failed to retrieve questions");
        }
    }

}
