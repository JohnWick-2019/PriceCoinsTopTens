using Microsoft.AspNetCore.Mvc;
using PriceCoinsTopTens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCoinsTopTens.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {          

            return View();
        }
    }
}
