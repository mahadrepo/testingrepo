using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class azurefunctionautomation
    {
        private readonly ILogger<azurefunctionautomation> _logger;

        public azurefunctionautomation(ILogger<azurefunctionautomation> logger)
        {
            _logger = logger;
        }

        [Function("azurefunctionautomation")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("mahad ");
        }
    }
}
