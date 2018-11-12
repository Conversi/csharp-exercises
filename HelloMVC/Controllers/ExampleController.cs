using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class ExampleController : Controller
    {
        [HttpGet]
        public IActionResult ExamplePage()
        {
            return Content(htmlString, "text/html");
        }
        [HttpPost]
        public IActionResult ExamplePage(string firstName, string lastName)
        {
            return Content(firstName, lastName);
        }
        string htmlString = @"<body>
                                <ul>
                                    <form action='/example/examplepage' method='post'>
                                    <input type='submit'>
                                    <input type='text' name='firstName'/>
                                    <input type='text' name='lastName'/>
                                    </form>
                                    <li>This</li>
                                    <li>is</li>
                                    <li>douchey</li>
                                    <li>example</li>
                                </ul>
                            </body>";
    }
}