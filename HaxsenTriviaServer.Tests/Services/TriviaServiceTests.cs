using Moq;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using HaxsenTriviaServer.Models;
using HaxsenTriviaServer.Services;
using Xunit;
using System.Net;


namespace HaxsenTriviaServerTests.Services
{
    public class TriviaServiceTests
    {
        private readonly Mock<IOpenTdbClient> _mockClient;
        private readonly TriviaService _triviaService;

        public TriviaServiceTests()
        {
            _mockClient = new Mock<IOpenTdbClient>();
            _triviaService = new TriviaService(_mockClient.Object);
        }

        [Fact]
        public async Task GetQuestionsAsync_ReturnsListOfTriviaQuestions()
        {
            // Arrange
            var mockQuestions = new List<TriviaQuestion>
        {
            new TriviaQuestion { Id = 1, Question = "Sample question", Options = new List<string> { "A", "B", "C", "D" }, CorrectAnswer = "A" }
        };

            var httpResponseMessage = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("[]", System.Text.Encoding.UTF8, "application/json")
            };
            var refitSettings = new RefitSettings();
            var mockApiResponse = new ApiResponse<List<TriviaQuestion>>(httpResponseMessage, mockQuestions, refitSettings);

            _mockClient.Setup(client => client.GetTriviaQuestions()).ReturnsAsync(mockApiResponse);

            // Act
            var result = await _triviaService.GetTriviaQuestionsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(mockQuestions, result);
            Assert.Equal("Sample question", result[0].Question);
            Assert.Equal("A", result[0].CorrectAnswer);
        }
    }
}
