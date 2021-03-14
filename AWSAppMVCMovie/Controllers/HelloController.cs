using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AWSAppMVCMovie.Controllers
{
    public class HelloController : Controller
    {

        //GET: /Hello
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Welcome(string firstName, string numTimes="1")
        {
            ViewData["Message"] = "Hello " + firstName;
            ViewData["numTimes"] = Convert.ToInt32(numTimes);
            return View();

        }
    }

}
