using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class MyFunction
    {
        // private readonly ILogger<unittesting> _logger;

        // public unittesting(ILogger<unittesting> logger)
        // {
        //     _logger = logger;
        // }

        [Function("unittesting")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {     

            // _logger.LogInformation("C# HTTP trigger function processed a request.");
            string name = req.Query["name"];
            
            return new OkObjectResult("Hello "+ (name ?? ""));
        }
    }
}
