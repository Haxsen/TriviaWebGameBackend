using RestSharp;
using System.Threading.Tasks;

namespace HaxsenTriviaServer
{
    public class OpenTriviaService
    {
        private readonly string _baseUrl;
        private readonly RestClient _client;

        public OpenTriviaService()
        {
            _baseUrl = "https://opentdb.com";
            _client = new RestClient(_baseUrl);
        }

        public async Task<string> GetTriviaQuestionsAsync(int amount = 10)
        {
            var request = new RestRequest($"/api.php?amount={amount}", Method.Get);
            var response = await _client.ExecuteAsync(request);
            return response.Content;
        }
    }

}
