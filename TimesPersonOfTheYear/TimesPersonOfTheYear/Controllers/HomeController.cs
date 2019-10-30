using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimesPersonOfTheYear.Models;

namespace TimesPersonOfTheYear.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var random = TimePerson.GetPersons(1950, 1960);
            return View();
        }
    }
}
