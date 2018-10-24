using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;

namespace Lab_4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["TimeOfDay"] = timeOfDay();
            DateTime date = DateTime.Now;
            return View(date);
        }

        public string timeOfDay()
        {
            if (DateTime.Now.Hour < 12)
            {
                return "Good Morning";
            }
            else if (DateTime.Now.Hour < 18)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good Evening";
            }
        }

        public IActionResult Waffler()
        {
            ViewData["TimeOfDay"] = timeOfDay();
            return View("Waffler");
        }
    }
}