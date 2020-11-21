﻿using LabAssignment4_NETD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
                ViewData["Message"] = text.ToString();
                ViewData["Appraisal"] = "We will pay $" + text.CalculateCost().ToString() + " for your Textbook " + text.title;

                return View("Appraised", text);
            }
            else
            {
                return View("Bad");
            }
        }
    }
}
