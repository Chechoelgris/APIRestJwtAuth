using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIRest.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/student")]
    public class WeatherForecastController : ControllerBase
    {
         

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [Authorize(Policy = "RequireEstudianteRole")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("ok ok");
        }
    }
}
