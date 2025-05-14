using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AuthorizationFunction
{
    public class Authorize
    {
        private readonly ILogger<Authorize> _logger;

        public Authorize(ILogger<Authorize> logger)
        {
            _logger = logger;
        }

        [Function("Authorize")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
