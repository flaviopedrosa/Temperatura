using Microsoft.AspNetCore.Mvc;

namespace Temperatura.Controllers
{
    public class ConversaoController : Controller
    {
        [Produces("application/json")]
        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult Get(float celsius)
        {
            float fahrenheit;
            fahrenheit = (1.8f * celsius) + 32;
            return View(fahrenheit);
        }
    }
}