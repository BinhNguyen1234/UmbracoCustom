using Core.BlogModel;
using Core.Data;
using Core.Data.Infrastucture;
using Core.Data.Model;
using Core.Data.Repositories;
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
    public class Config : Controller
    {
        private readonly IRouteRepository _routes;
        private readonly IDatabase _cached;
        private readonly ICmsService _cmsService;
        public Config(IRouteRepository routes, IDatabase cached, ICmsService cmsService) {
            this._routes = routes;
            this._cached = cached;  
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
            //var d = _coreContext.Homes.Add(home);
            //var e = _coreContext.Persons.Add(c);
            //var l = _coreContext.ChangeTracker.Entries().Where(e => true).ToList();
            //_coreContext.SaveChanges();
            var chanel = GrpcChannel.ForAddress("https://localhost:44338");
            var client = new TestHello.TestHelloClient(chanel);
            var rsgrpc = client.SayHello(new HelloRequest { Name = "Bin" });
            return Json(data);
        }
        [HttpGet]
        public async Task<IActionResult> GetRoutesConfig()
        {
            //step 1: get content in cached if not exist we will invoked step 2
            

            //step 2: get content in Db, if not exist we invoked step 3
            var db = this._routes.GetAll();
            // step 3: get content in CMS, than store to Db and send Db to caching
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
