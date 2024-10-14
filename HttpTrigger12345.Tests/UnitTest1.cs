using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.IO;
using System.Text;
using Xunit;

namespace HttpTrigger12345.Tests
{
    public class HttpTrigger12345Tests
    {
        private readonly Mock<ILogger<Company.Function.HttpTrigger12345>> _mockLogger; // Use fully qualified name for logger
        private readonly Company.Function.HttpTrigger12345 _function; // Use fully qualified name for the function

        public HttpTrigger12345Tests()
        {
            _mockLogger = new Mock<ILogger<Company.Function.HttpTrigger12345>>();
            _function = new Company.Function.HttpTrigger12345(_mockLogger.Object); // Use fully qualified name for the function
        }

        [Fact]
        public async Task Run_ReturnsOkObjectResult()
        {
            // Arrange
            var context = new DefaultHttpContext();
            var request = context.Request;
            request.Method = "GET"; // or "POST"
            request.Body = new MemoryStream(Encoding.UTF8.GetBytes(""));

            // Act
            var result = _function.Run(request);

            // Assert
            var okResult = Xunit.Assert.IsType<OkObjectResult>(result);
            Xunit.Assert.Equal("Welcome to Azure Functions!", okResult.Value);
        }
    }
}
