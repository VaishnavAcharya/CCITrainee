using System.Linq;
using System.Web.Mvc;
using UsingJqueryDataTables.Models;
using UsingJqueryDataTables.ViewModel;

namespace UsingJqueryDataTables.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            OrderDetailsViewModel mod = new OrderDetailsViewModel();
            NorthwindEntities db = new NorthwindEntities();
            mod.OrderDetails= db.Order_Details.ToList();
            return View(mod);
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