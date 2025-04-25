using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] users = new[]
        {
            "John", "Alice", "Marc"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(users);
        }
    }
}
