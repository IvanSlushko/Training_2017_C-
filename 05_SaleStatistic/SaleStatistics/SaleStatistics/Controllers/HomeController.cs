using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaleStatistics.Models;
using BL;

namespace SaleStatistics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sales()
        {
            var repositoryTransfer = new RepoTransfer();
            var salesDTO = repositoryTransfer.GetSales();
            var sales = salesDTO.Select(s => new SaleInfo()
            {
                Id = s.Id,
                Date = s.Date,
                Manager = s.Manager,
                Client = s.Client,
                Product = s.Product,
                PriceSum = s.PriceSum
            }).ToArray();
            return View(sales);
        }

        public ActionResult Managers()
        {
            var repositoryTransfer = new RepoTransfer();
            var managersDTO = repositoryTransfer.GetManagers();
            var managers = managersDTO.Select(m => new Manager()
            {
                SecondName = m.SecondName
            }).ToArray();
            return View(managers);
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