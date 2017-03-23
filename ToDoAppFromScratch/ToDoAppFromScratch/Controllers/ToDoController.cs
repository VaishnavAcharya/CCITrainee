using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoAppFromScratch.Models;
using ToDoAppFromScratch.ViewModels.ToDo;

namespace ToDoAppFromScratch.Controllers
{
    public class ToDoController : Controller
    {
        ToDoEntity db = new ToDoEntity();
        public ActionResult Index()
        {
            ToDoViewModel todolist = new ToDoViewModel();
            todolist.TaskTable = db.Tasks.ToList();
            return View(todolist);
        }

        public ActionResult AddItem(ToDoViewModel mod)
        {
            if(mod.Id==0)
            {
                Tasks task = new Tasks();
                task.TaskName = mod.TaskName;
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            
            else
            {
                Tasks EditTask = db.Tasks.Find(mod.Id);
                EditTask.TaskName = mod.TaskName;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveItem(ToDoViewModel mod)
        {
            Tasks DeleteTask = db.Tasks.Find(mod.Id);
            db.Tasks.Remove(DeleteTask);
            db.SaveChanges();
            mod.Id = 0;
            return RedirectToAction("Index");

        }

        public ActionResult EditItem(ToDoViewModel mod)
        {
            Tasks EditTask = db.Tasks.Find(mod.Id);
            mod.TaskName = EditTask.TaskName;
            mod.Id = EditTask.Id;
            //ToDoViewModel todolist = new ToDoViewModel();
            //todolist.TaskTable = db.Tasks.ToList();
            mod.TaskTable = db.Tasks.ToList();
            return View("Index", mod);

        }
    }
}