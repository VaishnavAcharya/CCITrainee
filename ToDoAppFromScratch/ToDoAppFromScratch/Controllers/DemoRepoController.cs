using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoAppFromScratch.Models;
using ToDoAppFromScratch.Repository;
using ToDoAppFromScratch.UnitOfWork;
using ToDoAppFromScratch.ViewModels.ToDo;

namespace ToDoAppFromScratch.Controllers
{
    public class DemoRepoController : Controller
    {
        GenericUnitOfWork unitOfWork;
        // GET: DemoRepo
        public ActionResult Index()
        {
            unitOfWork = new GenericUnitOfWork();
            ToDoViewModel toDoList = new ToDoViewModel();
            toDoList.TaskTable = unitOfWork.GetRepoInstance<Tasks>().SelectAll();
            return View(toDoList);
        }

        public ActionResult AddEditItem(Tasks task)
        {
            unitOfWork = new GenericUnitOfWork();
            GenericRepository<Tasks> tasksRepo = unitOfWork.GetRepoInstance<Tasks>();

            if (task.Id == 0)
            {
                tasksRepo.Insert(task);

            }

            else
            {
                Tasks taskToUpdate = tasksRepo.SelectByID(task.Id);
                taskToUpdate.TaskName = task.TaskName;
            }
            unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveItem(Tasks task)
        {
            unitOfWork = new GenericUnitOfWork();
            GenericRepository<Tasks> tasksRepo = unitOfWork.GetRepoInstance<Tasks>();
            tasksRepo.Delete(task.Id);
            unitOfWork.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult EditItem(int Id)
        {
            unitOfWork = new GenericUnitOfWork();
            GenericRepository<Tasks> tasksRepo = unitOfWork.GetRepoInstance<Tasks>();
            Tasks taskToEdit = tasksRepo.SelectByID(Id);

            ToDoViewModel mod = new ToDoViewModel();
            mod.Id = taskToEdit.Id;
            mod.TaskName = taskToEdit.TaskName;
            mod.TaskTable = tasksRepo.SelectAll();
            return View("Index", mod);

        }
    }
}