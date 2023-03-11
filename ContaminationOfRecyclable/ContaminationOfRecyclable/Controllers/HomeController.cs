using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContaminationOfRecyclable.Models;

namespace ContaminationOfRecyclable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult GetData()
        {
            Contamination_Models context = new Contamination_Models();
            var data = context.Contaminations
                .Select(p => new { period = p.period, rate = p.contamination_rate })
                .ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}