using AprilBatchMVCProject.Models;
using AprilBatchMVCProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AprilBatchMVCProject.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        EmpDAL db = new EmpDAL();
        public ActionResult Index()
        {
            var d=db.FetchEmp();
            return View(d);
        }

        public ActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmp(Emp e)
        {
            db.AddEmp(e);
            TempData["msg"] = "<script>alert('Emp Added Success!!')</script>";
            return View();
        }

        
    }
}