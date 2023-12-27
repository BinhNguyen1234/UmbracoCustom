using Core.BlogModel;
using Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;
using System.Text;
using System.Text.Json;
using static Azure.Core.HttpHeader;

namespace Core.ControllerApi
{
    [Route("[controller]/[action]")]
    public class Test : Controller
    {
        private TestContext _cmsContext;
        private IDatabase _cached;
        public Test(TestContext context, IDatabase cached) {
            this._cmsContext = context;
            this._cached = cached;  
        }

        [HttpGet]
        public IActionResult Index()
        {

            var aa = new AB()
            {
                name = "18",
                age = "bi"
            };
            var json = JsonSerializer.Serialize<AB>(aa);
            _cached.StringSet("f6:f7", json);
            //var tt = _cached.StringGet("f4");
            //var de = Encoding.UTF8.GetString(tt);
            var js = JsonSerializer.Deserialize<AB>(json);

            return Json(js);
        }
        [HttpPost]
        public IActionResult TestPost([FromBody]TestForm data) {
            var home = new Home() { Address = "fffasdasd" };
            var c = new Persons() { Name = "Buinh", Home = home };
            var d = _cmsContext.Homes.AsNoTracking().Where(x => true).ToList();
            var l = _cmsContext.ChangeTracker.Entries().Where(e => true).ToList();
            _cmsContext.SaveChanges();

            return Json(data);
        }
    }
    public class AB
    {
        public string name { get; set; }
        public string age { get; set; }
    }
    public class TestForm { 
        public string form1 { get; set; }
        public string form2 { get; set; }
        public string form3 { get; set; }       
    }
}
