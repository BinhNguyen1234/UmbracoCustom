using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.Controllers;

namespace CmsCore.ControllerCustom
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : UmbracoController
    {
        [HttpGet]
        public IActionResult name()
        {
            return Ok("binh");
        } 
    }
}
