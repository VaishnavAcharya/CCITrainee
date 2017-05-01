using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCToDoList.Models
{
    public class ListModel
    {
        public string Item { get; set; }
        public int id { get; set; }

        //public static Dictionary<int, string> Todos { get; set; }

        //static ListModel() //constructor
        //{
        //    Todos = new Dictionary<int, string>();
        //}

        public List<ItemsTable> itemsTable { get; set; }
    }
}