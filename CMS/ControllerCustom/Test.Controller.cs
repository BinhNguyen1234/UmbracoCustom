using CMS.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CmsCore.ControllerCustom
{
    
    [ApiRouteAtribute("[controller]/[action]")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult name()
        {
            return Ok("binh");
        }
        [HttpGet]
        public IActionResult Age()
        {
            return Ok("25");
        }
    }  
}
