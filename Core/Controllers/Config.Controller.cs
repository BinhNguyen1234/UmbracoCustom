using Core.BlogModel;
using Core.Infrastructure.Database;
using Core.Infrastructure.Database.Infrastucture;
using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Core.Infrastructure.Services.Cms;
using Core.Services.Interface;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;
using StackExchange.Redis;
using System.Text;
using System.Text.Json;

namespace Core.Controllers
{
    [Route("[controller]/[action]")]
    public class Config : ControllerBase
    {
        private readonly IRoutesService _routesService;
        private readonly IDatabase _cached;
        public Config(IRoutesService routesService, IDatabase cached) {
            this._routesService = routesService;
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

            return Ok(js);
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
            return Ok(data);
        }
        [HttpGet]
        public async Task<IActionResult> GetRoutesConfig()
        {
            //step 1: get content in cached if not exist we will invoked step 2


            //step 2: get content in Db, if not exist we invoked step 3
            var data = await this._routesService.GetAllRoutesFromDb();
            if (data.IsNullOrEmpty())
            {
                data = await this._routesService.AddRoutesToDbIfNotExist();
            }
            return Ok(data);
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
