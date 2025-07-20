using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("secret")]
        [Authorize]
        public IActionResult GetSecret()
        {
            return Ok("🎉 You have accessed a protected endpoint!");
        }

        [HttpGet("public")]
        public IActionResult GetPublic()
        {
            return Ok("🌐 This is a public endpoint, no token needed.");
        }
    }
}
