using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        //local:port/demo/chuoi
        public string Chuoi()
        {
            return "hello";
        }
        public int So() 
        {
            return new Random().Next(1000, 10000);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}