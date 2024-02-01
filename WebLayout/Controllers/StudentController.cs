using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLayout.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.msg = "Student Home Page";

            return View();
        }

        public ActionResult NameList()
        {
            List<string> list = new List<string>()
            {
                "Ravi",
                "Raj",
                "Nitu",
                "Ria"
            };
            ViewBag.nameList = list;

            return View();
        }
    }
}