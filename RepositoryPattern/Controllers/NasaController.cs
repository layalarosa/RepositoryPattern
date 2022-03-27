using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NasaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            string url = "https://api.nasa.gov/planetary/apod?api_key=M3x3iYeC2QVWXeuHzZuh4zxkdH2RgptpmXArsVwg";
            using var client = new HttpClient();
            var content =
                await client.GetStringAsync(url);
            return Ok(content);
        }
    }
}
