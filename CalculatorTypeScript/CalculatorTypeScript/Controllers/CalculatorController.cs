using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorTypeScript.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Calc()
        {
            return View();
        }
    }
}