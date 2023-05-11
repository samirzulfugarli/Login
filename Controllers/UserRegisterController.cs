using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
