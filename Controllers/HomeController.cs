using LabAssignment4_NETD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LabAssignment4_NETD.Controllers
{
    public class HomeController : Controller
    {
        List<Textbook> textbookList = new List<Textbook>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Appraise()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appraise(Textbook text)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "Your Textbook: " + text.title + ", Version: " + text.version + " is in " + text.condition + " condition.";
                ViewData["Appraisal"] = "This means we will pay you $" + text.CalculateCost().ToString() + " for your Textbook";

                return View("Appraised", text);
            }
            else
            {
                return View("Bad");
            }
        }
    }
}
