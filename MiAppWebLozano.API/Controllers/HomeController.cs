using Microsoft.AspNetCore.Mvc;

namespace MiAppWebLozano.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hola desde tu API en .NET");
        }
    }
}