using Core.BlogModel;
using Core.Data;
using Core.Service.Cms;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;
using System.Text;
using System.Text.Json;

namespace Core.ControllerApi
{
    [Route("[controller]/[action]")]
    public class Test : Controller
    {
        private readonly TestContext _cmsContext;
        private readonly IDatabase _cached;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICmsService _cmsService;
        public Test(TestContext context, IDatabase cached, IHttpClientFactory httpClientFactory, ICmsService cmsService) {
            this._cmsContext = context;
            this._cached = cached;  
            this._httpClientFactory = httpClientFactory;
            this._cmsService = cmsService;  
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
            var chanel = GrpcChannel.ForAddress("https://localhost:44338");
            var client = new TestHello.TestHelloClient(chanel);
            var rsgrpc = client.SayHello(new HelloRequest { Name = "Bin" });
            return Json(data);
        }
        [HttpGet]
        public async Task<IActionResult> GetConfig()
        {
            var content = await this._cmsService.GetRoutesConfig();
            return Ok(content);
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
