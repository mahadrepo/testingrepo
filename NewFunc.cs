using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace automation_in_github
{
    public class NewFunc
    {
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {     
            // Log information can be added
            // _logger.LogInformation("C# HTTP trigger function processed a request.");
            
            string name = req.Query["name"];
            
            return new OkObjectResult("Hello " + (name ?? ""));
        }
    }
}
