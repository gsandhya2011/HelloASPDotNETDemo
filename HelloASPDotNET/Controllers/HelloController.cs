using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
      
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //Get: /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app," + name + "!</h1>", "text/html");
        //}

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }
        [Route("/hello/greeting")]
        [HttpPost]
        public IActionResult FormSubmission(string name, string language)
        {
            string greeting = CreateMessage(name, language);
            return Content(greeting, "text/html");
        }


        public static string CreateMessage(string name, string lang)
        {
            if(lang == "english")
            {
                return $"Greetings, {name}!";
            }
            else if(lang == "french")
            {
                return $"Bonjour, {name}!";
            }
            else if(lang == "spanish")
            {
                return $"iHola, {name}!";
            }
            else if(lang == "hindi")
            {
                return $"Namaste, {name}!";
            }
            else if(lang == "german")
            {
                return $"Guten tag, {name}!!???";
            }
            else if(lang == "telugu"){
                return $"Namaskaram, {name}!!";
            }
            return "No language selected!";
        }
    }
}
