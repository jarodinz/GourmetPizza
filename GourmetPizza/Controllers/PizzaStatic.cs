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
                //Now i need to times the cost by the amount of pizza then send it to the view. 
                //add in message
                //Pass the PizzaName and Cost through to the view.
            }
            return View();
        }
 

    }
}
