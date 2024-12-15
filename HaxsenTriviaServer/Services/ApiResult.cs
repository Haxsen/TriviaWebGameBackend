using HaxsenTriviaServer.Models;

namespace HaxsenTriviaServer.Services
{
    public class ApiResult
    {
        public int response_code { get; set; }
        public List<TriviaQuestion> results { get; set; }
    }
}
