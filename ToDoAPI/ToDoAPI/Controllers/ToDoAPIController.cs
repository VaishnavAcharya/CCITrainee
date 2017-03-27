using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoAPI.Models;
using ToDoAPI.ViewModels.ToDo;

namespace ToDoAPI.Controllers
{

    public class ToDoAPIController : ApiController
    {
        ToDoContext db = new ToDoContext();

        [HttpGet]
        public IEnumerable<Tasks> TasksList()
        {
            ToDoViewModel todolist = new ToDoViewModel();
            todolist.TaskTable = db.Tasks.ToList();
            return todolist.TaskTable;
        }

        [HttpPost]
        public void AddTask([FromBody] string TaskName)
        {
            Tasks AddTask = new Tasks();
            AddTask.TaskName = TaskName;
            db.Tasks.Add(AddTask);
            db.SaveChanges();

        }

        [HttpDelete]
        public void DeleteDetails(int Id)
        {
            Tasks DeleteTask = db.Tasks.Find(Id);
            db.Tasks.Remove(DeleteTask);
            db.SaveChanges();

        }

        [HttpPut]
        public void SaveChanges(int Id, [FromBody]string TaskName)
        {
            Tasks EditTask = db.Tasks.Find(Id);
            EditTask.TaskName = TaskName;
            db.SaveChanges();
            
        }
    }
}
