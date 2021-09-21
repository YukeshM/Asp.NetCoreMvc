using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
       public IActionResult Index()
       {
            return View();
       }
        public string Welcome(string name, int num = 1)
        {
            return HtmlEncoder.Default.Encode($"hello {name} , you entered {num}");
        }
    }
}
