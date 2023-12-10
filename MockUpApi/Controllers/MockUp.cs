using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
namespace MockUpApi.Controllers
{
    [Route("[controller]/[action]")]
    public class MockUp : Controller
    {
        public MockUp()
        {
        }
        [HttpGet("{fileName}")]
        public IActionResult Get(string fileName)
        {

            try
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFile");
                DirectoryInfo folder = new DirectoryInfo(folderPath);
                FileSystemInfo? file = folder.GetFileSystemInfos($"*", SearchOption.AllDirectories).FirstOrDefault(x => x.Name.ToLower().Equals(fileName.ToLower()) || x.Name.ToLower().StartsWith(fileName.ToLower()));
                
                if (file == null)
                {
                    throw new FileNotFoundException(folderPath);
                }
                Console.WriteLine(file.FullName);
                string? line;
                FileStream fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    line = reader.ReadToEnd();
                }
                Console.WriteLine(line);
                return Ok(line);
            }
            catch (FileNotFoundException)
            {
                return NotFound("Not found file");
            }

        }
    }
}
