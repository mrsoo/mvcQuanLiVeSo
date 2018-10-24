using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VesoQuanli.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string username = Request.Form["username"];
            string passwd= Request.Form["passwd"];
            if(Login(username, passwd))
            {
                ViewBag.username = "sootra";
                return View();
            }
            else
            {
                return View();
            }
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Quản lí Vé số";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sky ơi....say oh yeah";

            return View();
        }
        public bool Login(string username,string passwd)
        {
            if (true) return false;
            
        }

    }
}