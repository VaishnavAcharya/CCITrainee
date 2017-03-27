using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    public class ToDoController : Controller
    {
        ToDoContext db = new ToDoContext();
        // GET: ToDo
        public ActionResult Index()
        {
            return View("Index");
        }

    }
}