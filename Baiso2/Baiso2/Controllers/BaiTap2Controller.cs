using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baiso2.Models;

namespace Baiso2.Controllers
{
    public class BaiTap2Controller : Controller
    {
        // GET: BaiTap2
        giaibaitap2 gpt = new giaibaitap2();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BT2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BT2(double hsa, double hsb)
        {
            double x = gpt.giaiphuongtrinhbac1(hsa, hsb);
            ViewBag.nghiem = x;
            return View();
        }
    }
}