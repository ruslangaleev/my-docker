using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test Project");
        }
    }
}