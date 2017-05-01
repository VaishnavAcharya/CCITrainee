using MVCToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCToDoList.Controllers
{
    public class HomeController : Controller
    {
        ToDoListEntities db = new ToDoListEntities();

        public ActionResult Index()
        {
            ListModel listModel = new ListModel();
            listModel.itemsTable = db.ItemsTables.ToList();
            return View(listModel);
        }

        public ActionResult AddItem(ListModel mod)
        {

            if (mod.id == 0)
            {
                //ListModel.Todos.Add(ListModel.Todos.Count > 0 ? ListModel.Todos.Keys.Max() + 1 : 1, mod1.Item);
                ItemsTable itemsTable = new ItemsTable();
                itemsTable.Item = mod.Item;
                db.ItemsTables.Add(itemsTable);
                db.SaveChanges();

            }
            else
            {
                //ListModel.Todos[mod1.id] = mod1.Item;
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveItem(ListModel mod)
        {
            //ListModel.Todos.Remove(mod.id);
            //mod.id = 0;
            ItemsTable itemsTable = new ItemsTable();
            itemsTable.id = mod.id;
            db.ItemsTables.Remove(itemsTable);
            mod.id = 0;
            return RedirectToAction("Index");
        }

        public ActionResult EditItem(ListModel mod)
        {

            return View("Index"); //view is used so that the key is passed in the add
        }

        public ActionResult SearchItem(ListModel mod)
        {
            //foreach(var item in ListModel.Todos)
            //{
            //    if (item.Value.Contains(mod.Item))
            //    {
            //        mod.id = item.Key;
            //        mod.Item = item.Value;
            //    }
            //}
            return PartialView("_SearchItem", mod);

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}