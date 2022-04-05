using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           ViewBag.FifteenTip = 0;
            ViewBag.TwentyTip = 0;
            ViewBag.TwentyFiveTip = 0;
           return View();
        }

        [HttpPost]
        public IActionResult Index (Calculator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FifteenTip = model.FifteenTip();
            }
            else
            {
                model.MealCost = 0;
            }
            if (ModelState.IsValid)
            {
                ViewBag.TwentyTip = model.TwentyTip();
            }
            else
            {
                model.MealCost = 0;
            }
            if (ModelState.IsValid)
            {
                ViewBag.TwentyFiveTip = model.TwentyFiveTip();
            }
            else
            {
                model.MealCost = 0;
            }

            ViewBag.MealCost = model.MealCost;
            ViewBag.TwentyFiveTip = model.TwentyFiveTip();
            ViewBag.TwentyTip = model.TwentyTip();
            ViewBag.FifteenTip = model.FifteenTip();
            return View();








        }


    }
}
