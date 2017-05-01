using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoAppCodeFirst.Models;
using ToDoAppCodeFirst.ViewModels.Home;

namespace ToDoAppCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        ToDoContext db = new ToDoContext();
        public ActionResult Index()
        {

            //var tasks = db.Tasks.ToList();
            //tasks.Add(new Tasks { TaskName = "test" });
            //db.SaveChanges();
            ToDoViewModel todolist = new ToDoViewModel();
            todolist.itemsTable = db.Tasks.ToList();
            return View(todolist);
        }

        public ActionResult AddItem(ToDoViewModel mod)
        {
            if (mod.Id == 0)
            {
                Tasks task = new Tasks();
                task.TaskName = mod.TaskName;
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            else
            {
                //Tasks editTask = db.Tasks.SingleOrDefault(x => x.Id == mod.Id);
                Tasks editTask = db.Tasks.Find(mod.Id);
                editTask.TaskName = mod.TaskName;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditItem(ToDoViewModel mod)
        {
            ToDoViewModel todolist = new ToDoViewModel();
            todolist.itemsTable = db.Tasks.ToList();
            return View("Index", todolist);
        }

        

        public ActionResult RemoveItem(ToDoViewModel mod)
        {
            //Tasks taskDelete = from task in db.Tasks
            //                   where task.Id == mod.Id
            //                   select task;
            Tasks taskDelete = db.Tasks.First(x => x.Id == mod.Id);
            db.Tasks.Remove(taskDelete);
            db.SaveChanges();
            mod.Id = 0;
            return RedirectToAction("Index");
        }
    }
}