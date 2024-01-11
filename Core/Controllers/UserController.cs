using Core.DTO.RequesModel;
using Core.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) { 
            this._userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> Login()
        {
            return Ok("f");
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterForm form )
        {
            var r = await _userService.RegistUser(form);
            return Ok("f");
        }
    }
}
