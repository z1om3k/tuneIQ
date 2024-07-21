using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TuneIQ.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Check()
        {
            _logger.LogInformation("Health check endpoint hit");
            return Ok("Healthy");
        }
    }
}
