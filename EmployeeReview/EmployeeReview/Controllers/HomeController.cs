using EmployeeReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeReview.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RateEmployeeSkills(EmployeeModel emp)
        {
            
            return View();
        }
        public ActionResult RateDevSkills(EmployeeModel emp)
        {
            return View("RateDevSkills",emp);
        }

        public ActionResult RateTechSkills(EmployeeModel emp)
        {
            return View("RateTechSkills",emp);
        }

        public ActionResult DevSkillType(EmployeeModel emp)
        {
            //switch (emp.EmpDevSkills)
            //{
            //    case EmployeeModel.DevSkills.CodingSkills:
            //        emp.EmpDevSkills = EmployeeModel.DevSkills.QualityAssurance;
            //        break;
            //    case EmployeeModel.DevSkills.QualityAssurance:
            //        emp.EmpDevSkills = EmployeeModel.DevSkills.TimeLogging;
            //        break;
            //    case EmployeeModel.DevSkills.TimeLogging:
            //        emp.EmpDevSkills = EmployeeModel.DevSkills.TroubleShootingSkills;
            //        break;
            //    case EmployeeModel.DevSkills.TroubleShootingSkills:
            //        return View("RateEmployeeSkills");

            //}

            return PartialView("_DevSkillType",emp);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}