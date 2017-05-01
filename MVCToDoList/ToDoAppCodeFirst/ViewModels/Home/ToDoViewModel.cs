using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoAppCodeFirst.Models;

namespace ToDoAppCodeFirst.ViewModels.Home
{
    public class ToDoViewModel
    {
        public string TaskName { get; set; }
        public int Id { get; set; }

        //public static Dictionary<int, string> Todos { get; set; }

        //static ListModel() //constructor
        //{
        //    Todos = new Dictionary<int, string>();
        //}

        public List<Tasks> itemsTable { get; set; }
    }
}