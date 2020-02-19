using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_smart_door_sys.Models;

namespace Employee_smart_door_sys.Controllers
{
    public class HomeController : Controller
    {
        ep_listEntities db = new ep_listEntities();
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult employee_list()
        {

            var ep_list = db.ep_Table.OrderByDescending(m => m.ep_Id).ToList();

            return View(ep_list);
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