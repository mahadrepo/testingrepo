using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class Program
    {
        private readonly ILogger<Program> _logger;

        public Program(ILogger<Program> logger)
        {
            _logger = logger;
        }

        [Function("MyFunction")] // Rename function for clarity
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req, FunctionContext context)
        {
            _logger.LogInformation("C# HTTPppppppppp trigger function processed a request.");

            string name = req.Query["name"];

            return new OkObjectResult("Hello " + (name ?? ""));
        }
    }
}
