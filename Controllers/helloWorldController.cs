using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class helloWorldController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }

    public IActionResult Welcome(string name, int id = 1)
    {
        //return "welcome to my application";

        // return HtmlEncoder.Default.Encode($"Hello {name}, numtimes is: {numTimes}");

        ViewData["message"] = "hello" + name;
        ViewData["numTimes"] = id;
        return View();
    }
       

    }
}


