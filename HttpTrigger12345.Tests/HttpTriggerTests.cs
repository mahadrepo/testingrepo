using Xunit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Moq;  // For mocking dependencies
using HttpTrigger12345;  // Namespace of your function project

public class HttpTriggerTests
{
    [Fact]
    public async Task HttpTrigger_Should_Return_OK()
    {
        // Arrange
        var mockRequest = new Mock<HttpRequest>();  // Mocking HttpRequest
        var logger = new Mock<ILogger>();           // Mocking Logger

        // Act
        var result = await HttpTrigger12345.Run(mockRequest.Object, logger.Object) as OkObjectResult;

        // Assert
        Assert.Equal(200, result.StatusCode);
    }
}
