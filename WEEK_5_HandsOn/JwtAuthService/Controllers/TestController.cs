using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        // 🔓 No auth needed
        [HttpGet("public")]
        public IActionResult Public()
        {
            return Ok("This is a public endpoint.");
        }

        // 🔒 Protected with JWT token
        [Authorize]
        [HttpGet("secure")]
        public IActionResult Secure()
        {
            return Ok("This is a protected endpoint!");
        }
    }
}
