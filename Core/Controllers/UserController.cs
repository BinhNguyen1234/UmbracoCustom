using Core.DTO.RequesModel;
using Core.Infrastructure.Database.Model;
using Core.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _config;
        public UserController(IUserService userService, IConfiguration config) { 
            this._userService = userService;
            _config = config;
        }
        [HttpPost]
        public async Task<IActionResult> Authenticate(LoginForm form)
        {
            var c = HttpContext;
            var token = GenerateToken(new User { Name = "binh", Email = "fasf", Password = "ffff" });
           
            return Ok(new
            {
                token = token
            });
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Authozire()
        {
            var currentUser = HttpContext.User;
            return Ok("Ok");
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterForm form )
        {
            var r = await _userService.RegistUser(form);
            return Ok("f");
        }
        [NonAction]
        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Name),
            }; 
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
