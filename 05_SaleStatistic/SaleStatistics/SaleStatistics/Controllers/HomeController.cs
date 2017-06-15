using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace SaleStatistics.Controllers
{
    public class HomeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            var repositoryTransfer = new RepoTransfer();
            ViewBag.Sales = repositoryTransfer.GetSales();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ivan Slushko";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "lu813@tut.by";
            return View();
        }
    }
}