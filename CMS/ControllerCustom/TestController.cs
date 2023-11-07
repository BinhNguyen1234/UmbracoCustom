using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsCore.ControllerCustom
{
    [Route("[controller]/[action]")]
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
