using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2dayne.Controllers
{
    public class HelloController : Controller
    {
        [Route("Hi")]
        public IActionResult Index()
        {
            return View();
        }
        // [Route("Welcome/{name?}/{numTimes?}")]
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] ="Hello" + name;
            ViewBag.Name = name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}
