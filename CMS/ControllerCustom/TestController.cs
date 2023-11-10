using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CmsCore.ControllerCustom
{
    [Route("[controller]/[action]")]
    [Authorize]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult name()
        {
            return Ok("binh");
        } 
    }
}
