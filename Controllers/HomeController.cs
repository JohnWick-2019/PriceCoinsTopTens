using Microsoft.AspNetCore.Mvc;
using PriceCoinsTopTens.Models;
using PriceCoinsTopTens.WorkClasses;
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
            GetListCriptocurrenciName getListCriptocurrenciName = new();
            GetCriptocurrenciPrice getCriptocurrenciPrice = new();            

            DataNameAndPriceCripto dataNameAndPriceCripto = new()
            {
                NameCripto = getListCriptocurrenciName.GetCriptocurrenciName(),
                PriceCripto = getCriptocurrenciPrice.GetPrice()
            };

            return View(dataNameAndPriceCripto);
        }
    }
}
