using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GourmetPizza.Controllers
{
    public class PizzaStatic : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();

        }

        public ActionResult Purchase(int PizzaType, int PizzaCount)
        {
            if (PizzaType == 1)
            {   
                double PizzaCost = 10.50;
                double Price = PizzaCost * PizzaCount;
                ViewBag.Price = Price;
                ViewBag.PizzaType = PizzaType;
            }

            if (PizzaType == 2)
            {
                double PizzaCost = 8.50;
                double Price = PizzaCost * PizzaCount;
                ViewBag.Price = Price;
                ViewBag.PizzaType = PizzaType;
            }

            if (PizzaType == 3)
            {
                double PizzaCost = 9.00;
                double Price = PizzaCost * PizzaCount;
                ViewBag.Price = Price;
                ViewBag.PizzaType = PizzaType;
            }

            if (PizzaType == 4)
            {
                double PizzaCost = 7.00;
                double Price = PizzaCost * PizzaCount;
                ViewBag.Price = Price;
                ViewBag.PizzaType = PizzaType;
            }

            return View();
        }
 

    }
}
