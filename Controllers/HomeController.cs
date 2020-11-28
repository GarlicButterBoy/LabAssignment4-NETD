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
        //Global List to store objects
        public List<Textbook> textbookList = new List<Textbook>();

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
                //Meant to add the newly created object to the list
                textbookList.Add(text);
                ViewData["Message"] = "Your Textbook: " + text.title + ", Version: " + text.version.ToString() + " is in " + text.condition + " condition.";
                ViewData["Appraisal"] = "This means we will pay you $" + text.CalculateCost().ToString() + " for your Textbook";

                return View("Appraised", text);
            }
            else
            {
                return View("Bad");
            }
        }

        public IActionResult ViewAppraisals()
        {
            Textbook testText = new Textbook();
            //First Object
            testText.title = "First Text";
            testText.isbn = "1215-ADFS-34DE-FR45";
            testText.version = 2.2;
            testText.price = 350;
            testText.condition = "Okay";
            textbookList.Add(testText);
            //Second Object
            testText.title = "Second Text";
            testText.isbn = "1215-ADFdS-34DEs-FR45";
            testText.version = 2.5;
            testText.price = 32;
            testText.condition = "Bad";
            textbookList.Add(testText);

            //Returns the listview
            return View(textbookList);
        }


    }
}
