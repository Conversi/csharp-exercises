﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" + 
                "<input type='text' name='name' /> + " +
                "< label for= 'pet-select' > Choose a pet:</ label >" +
                
                "< select id = 'pet-select' >" +
 
                     "< option value = '' > --Please choose an option-- </ option >" +
 
                     "< option value = 'French' > Fr </ option >" +
 
                     "< option value = 'Spanish' > Sp </ option >" +
 
                     "< option value = 'English' > En </ option >" +
 
                     "< option value = 'German' > De </ option >" +
 
                     "< option value = 'Chinese'> Cn </ option >" +
 
                "</ select >" +


                 "<input type='submit' value='Greet Me!' /> + " +
                "</form>";

            return Redirect("/Hello/Index");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
        }

        //Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
