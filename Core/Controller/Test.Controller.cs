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
        private readonly TestContext _cmsContext;
        private readonly IDatabase _cached;
        private readonly IHttpClientFactory _httpClientFactory;
        public Test(TestContext context, IDatabase cached, IHttpClientFactory httpClientFactory) {
            this._cmsContext = context;
            this._cached = cached;  
            this._httpClientFactory = httpClientFactory;
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
        public IActionResult TestPost([FromBody] TestForm data)
        {
            var home = new Home() { Address = "fffasdasd" };
            var c = new Persons() { Name = "Buinh", Home = home };
            var d = _cmsContext.Homes.Add(home);
            var e = _cmsContext.Persons.Add(c);
            var l = _cmsContext.ChangeTracker.Entries().Where(e => true).ToList();
            _cmsContext.SaveChanges();

            return Json(data);
        }
        [HttpGet]
        public async Task<IActionResult> CallCms()
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("https://localhost:44338");
            var rs = await httpClient.GetAsync("umbraco/delivery/api/v2/content?skip=0&take=10&fields=properties%5B%24all%5D");
            var content = await rs.Content.ReadAsStringAsync();
            return Ok("success");
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
