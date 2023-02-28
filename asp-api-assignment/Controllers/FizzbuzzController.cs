using Microsoft.AspNetCore.Mvc;

namespace asp_api_assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzbuzzController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FizzbuzzController> _logger;

        public FizzbuzzController(ILogger<FizzbuzzController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "fizzbuzz")]
        public FizzbuzzResult Get()
        {
            List<int> range = new List<int>(Enumerable.Range(0, 31));
            List<string> mappedRange = range.ConvertAll((number) =>
            {
                string message = "";
                if (number % 3 == 0) message += "fizz";
                if (number % 5 == 0) message += "buzz";
                if (message.Length == 0) message += number;
                message += "\n";
                return message;
            });
            return new FizzbuzzResult { Result = mappedRange };
        }
    }
}