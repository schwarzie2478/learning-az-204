using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AZ204.Samples.Functions
{
    public class SimpleHttpTrigger
    {
        private readonly ILogger<SimpleHttpTrigger> _logger;

        public SimpleHttpTrigger(ILogger<SimpleHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("SimpleHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
