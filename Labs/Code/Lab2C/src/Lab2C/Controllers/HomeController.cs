using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2C.Controllers
{
    public class HomeController
    {
        [HttpGet("/")]
        public string Index() => "Hello from MVC!";
    }
}
