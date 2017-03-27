using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoAPI.Models;

namespace ToDoAPI.ViewModels.ToDo
{
    public class ToDoViewModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }

        public List<Tasks> TaskTable { get; set; }
    }
}