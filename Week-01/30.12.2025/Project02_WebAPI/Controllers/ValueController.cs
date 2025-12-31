using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project02_WebAPI.Controllers
{
    [Route("api/[controller]")]  // /api/value
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet] // /api/value
        public string   Hello()
        {
            return "Hello World!";
        }
        [HttpGet("bye")] // /api/value/bye
       // [Route("bye")]
        public string GoodBye()
        {
            return "Good Bye";
        }
    }
}
