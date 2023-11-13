using Microsoft.AspNetCore.Mvc;

namespace Core.ControllerApi
{
    [Route("[controller]/[action]")]
    public class Test : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Done");
        }
    }
}
