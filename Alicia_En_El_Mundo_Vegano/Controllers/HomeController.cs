using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alicia_En_El_Mundo_Vegano.Models;

namespace Alicia_En_El_Mundo_Vegano.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Find Out More About Us!";

            return View();
        }
        public IActionResult Vision()
        {
            ViewData["Message"] = "Vision";

            return View();
        }
        public IActionResult Cause()
        {
            ViewData["Message"] = "Cause";

            return View();
        }
        public IActionResult Goal()
        {
            ViewData["Message"] = "Goals";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Feel Free To Reach Out To Us!";

            return View();
        }
        public IActionResult Recipes()
        {
            ViewData["Message"] = "Recipes are here";

            return View();
        }
        public IActionResult IndexEs()
        {
            return View();
        }

        public IActionResult AboutEs()
        {
            ViewData["Message"] = "¡Descubra más sobre nosotros!";

            return View();
        }
        public IActionResult VisionEs()
        {
            ViewData["Message"] = "Visión";

            return View();
        }
        public IActionResult CauseEs()
        {
            ViewData["Message"] = "Causa";

            return View();
        }
        public IActionResult GoalEs()
        {
            ViewData["Message"] = "Objetivos";

            return View();
        }
        public IActionResult ContactEs()
        {
            ViewData["Message"] = "¡Siéntete libre de contactarnos!";

            return View();
        }
        public IActionResult RecipesEs()
        {
            ViewData["Message"] = "Las recetas están aquí";

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
