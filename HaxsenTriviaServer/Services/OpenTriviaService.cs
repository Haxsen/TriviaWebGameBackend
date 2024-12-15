using RestSharp;
using System.Threading.Tasks;


namespace HaxsenTriviaServer.Services
{

    /// <summary>
    /// Service for fetching trivia questions from the Open Trivia Database.
    /// </summary>
    //public class OpenTriviaService : ITriviaService
    public class OpenTriviaService
    {
        private readonly string _baseUrl;
        private readonly RestClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTriviaService"/> class.
        /// </summary>
        public OpenTriviaService()
        {
            _baseUrl = "https://opentdb.com";
            _client = new RestClient(_baseUrl);
        }

        /// <summary>
        /// Fetches trivia questions from the Open Trivia Database.
        /// </summary>
        /// <param name="amount">The number of trivia questions to fetch.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the trivia questions in JSON format.</returns>
        public async Task<string> GetTriviaQuestionsAsync(int amount = 10)
        {
            var request = new RestRequest($"/api.php?amount={amount}", Method.Get);
            var response = await _client.ExecuteAsync(request);
            return response.Content;
        }
    }
}
