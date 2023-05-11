using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Login.BLL.Abstract;
using Project_Login.DAL.Abstract;
using Project_Login.Dtos.UserRegisterDtos;

namespace Project_Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRegisterService _userRegisterService;
        private readonly IUserRegisterRepository _userRegisterRepository;
        public UserRegisterController(IUserRegisterRepository userRegisterRepository, IUserRegisterService userRegisterService)
        {
            _userRegisterRepository = userRegisterRepository;
            _userRegisterService = userRegisterService;
        }
        [HttpPost]
        public IActionResult Add(UserRegisterToAddDtos dto)
        {
            _userRegisterService.Add(dto);
            return Ok();
        }
        [HttpPost("{login}")]
      public IActionResult Check([FromBody] CheckLoginDto login)
        {
            var user = _userRegisterService.Check(login.Username, login.Password);
            if (user == null)
                return BadRequest(new {message= "Sehv Login" });
            return Ok(user);
        }

    }
}
