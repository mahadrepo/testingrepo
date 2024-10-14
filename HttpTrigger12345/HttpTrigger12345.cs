using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class HttpTrigger12345
    {
        private readonly ILogger<HttpTrigger12345> _logger;

        public HttpTrigger12345(ILogger<HttpTrigger12345> logger)
        {
            _logger = logger;
        }

        [Function("HttpTrigger12345")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
