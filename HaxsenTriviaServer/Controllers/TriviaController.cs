using HaxsenTriviaServer.Models;
using HaxsenTriviaServer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HaxsenTriviaServer.Controllers
{

    /// <summary>
    /// API Controller to retrieve trivia questions.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TriviaController : ControllerBase
    {
        private readonly ITriviaService _triviaService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TriviaController"/> class.
        /// </summary>
        /// <param name="triviaService">The trivia service.</param>
        public TriviaController(ITriviaService triviaService)
        {
            _triviaService = triviaService;
        }

        /// <summary>
        /// Gets a list of trivia questions.
        /// </summary>
        /// <returns>A list of trivia questions.</returns>
        [HttpGet("questions")]
        public async Task<ActionResult<List<TriviaQuestion>>> Get()
        {
            var questions = await _triviaService.GetTriviaQuestionsAsync();
            return Ok(questions);
        }
    }

}
