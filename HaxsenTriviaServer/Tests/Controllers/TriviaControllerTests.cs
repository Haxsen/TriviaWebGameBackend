using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HaxsenTriviaServer.Controllers;
//using HaxsenTriviaServer.Service;

namespace HaxsenTriviaServer.Tests.Controllers
{

    /// <summary>
    /// Unit tests for TriviaController
    /// </summary>
    public class TriviaControllerTests
    {
        //[Fact]
        //public async Task Get_ReturnsOkResult_WithTriviaQuestions()
        //{
        //    // Arrange
        //    var mockTriviaService = new Mock<ITriviaService>();
        //    mockTriviaService.Setup(service => service.GetTriviaQuestionsAsync(It.IsAny<int>())).ReturnsAsync("mocked trivia questions");

        //    var controller = new TriviaController(mockTriviaService.Object);

        //    // Act
        //    var result = await controller.Get();

        //    // Assert
        //    var okResult = Assert.IsType<OkObjectResult>(result);
        //    Assert.Equal("mocked trivia questions", okResult.Value);
        //}
    }

}
