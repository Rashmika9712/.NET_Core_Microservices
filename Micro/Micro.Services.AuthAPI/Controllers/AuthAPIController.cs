using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;

namespace Micro.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult> Register()
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login()
        {
            return Ok();
        }
    }
}
