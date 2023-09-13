using Microsoft.AspNetCore.Mvc;

namespace WatiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : Controller
    {
        [HttpPost]
        public IActionResult Add([FromQuery]int num1, int num2)
        {
            return Ok(num1 + num2);
        }
    }
}
