using Microsoft.AspNetCore.Mvc;

namespace JordanDemoApi.Controllers
{
    [Route("")]
    public class TestController : Controller
    {
        [HttpGet("testget1")]
        public IActionResult TestGet()
        {
            return Ok();
        }

        [HttpGet("testget2")]
        public IActionResult TestGet2([FromQuery]string name)
        {
            return Ok($"Hello {name}");
        }

        [HttpPost("testpost1")]
        public IActionResult TestPost([FromBody]TestModel message)
        {
            return Ok(message);
        }

        [HttpPost("testpost2")]
        public IActionResult TestPost2([FromQuery]string message)
        {
            return Ok(message);
        }
    }

    public class TestModel
    {
        public string Message { get; set; }
    }
}