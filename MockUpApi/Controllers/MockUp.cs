using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
namespace MockUpApi.Controllers
{
    [Route("[controller]/[action]")]
    public class MockUp : Controller
    {
        public MockUp() {
        }
        [HttpGet("{fileName}")]
        public IActionResult Get(string fileName) {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Json", fileName);
            try
            {
                string? line;
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read,FileShare.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    line = reader.ReadToEnd();
                }
                Console.WriteLine(line);
                return Ok(line);
            }
            catch(FileNotFoundException) {
                return NotFound("Not found file");
            }

        }
    }
}
