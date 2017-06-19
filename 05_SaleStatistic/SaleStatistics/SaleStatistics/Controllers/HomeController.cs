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

        //!!!!!!!
        public ActionResult SalesList()
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
            return PartialView("PartialSalesList", sales);
        }

        //!!!!
        [HttpGet]
        public ActionResult SaleEdit(int id)
        {
            var repositoryTransfer = new RepoTransfer();
            var saleDTO = repositoryTransfer.GetSales().FirstOrDefault(s => (s.Id == id));
            var sale = new SaleInfo()
            {
                Id = saleDTO.Id,
                Date = saleDTO.Date,
                Manager = saleDTO.Manager,
                Client = saleDTO.Client,
                Product = saleDTO.Product,
                PriceSum = saleDTO.PriceSum
            };
            return PartialView("SaleEdit", sale);
        }

        //!!!!
        [HttpPost]
        public ActionResult SaleEdit(SaleInfo sale)
        {
            TryValidateModel(sale);
            if (ModelState.IsValid)
            {
                var repositoryTransfer = new RepoTransfer();
                var saleDTO = repositoryTransfer.GetSales().FirstOrDefault(s => (s.Id == sale.Id));
                saleDTO.Date = sale.Date;
                saleDTO.Manager = sale.Manager;
                saleDTO.Client = sale.Client;
                saleDTO.Product = sale.Product;
                saleDTO.PriceSum = sale.PriceSum;
                repositoryTransfer.UpdateSaleInfo(saleDTO);

                if (Request.IsAjaxRequest())
                {
                    return new EmptyResult();
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Error");
            }
        }





        public ActionResult Managers()
        {
            var repositoryTransfer = new RepoTransfer();
            var managersDTO = repositoryTransfer.GetManagers();
            var managers = managersDTO.Select(m => new Manager()
            {
                Id = m.Id,
                SecondName = m.SecondName
            }).ToArray();
            return View(managers);
        }

        public ActionResult ManagerList()
         {
             var repositoryTransfer = new RepoTransfer();
             var managersDTO = repositoryTransfer.GetManagers();
             var managers = managersDTO.Select(m => new Manager()
             {
                 Id = m.Id,
                 SecondName = m.SecondName
             }).ToArray();
 
             return PartialView("PartialManagersList", managers);
         }
 
         [HttpGet]
         public ActionResult ManagerEdit(int id)
         {
             var repositoryTransfer = new RepoTransfer();
             var managerDTO = repositoryTransfer.GetManagers().FirstOrDefault(m => (m.Id == id));
             var manager = new Manager()
             {
                 Id = managerDTO.Id,
                 SecondName = managerDTO.SecondName
             };
             return PartialView("ManagerEdit", manager);
         }
 
         [HttpPost]
         public ActionResult ManagerEdit(Manager manager)
         {
             TryValidateModel(manager);
             if (ModelState.IsValid)
             {
                 var repositoryTransfer = new RepoTransfer();
                 var managerDTO = repositoryTransfer.GetManagers().FirstOrDefault(m => (m.Id == manager.Id));
                 managerDTO.SecondName = manager.SecondName;
                 repositoryTransfer.UpdateManager(managerDTO);
 
                 if (Request.IsAjaxRequest())
                 {
                     return new EmptyResult();
                 }
                 else
                 {
                     return View("Index");
                 }
             }
             else
             {
                 return View("Error");
             }
         }

        public ActionResult ShowManager(int id)
         {
             var repositoryTransfer = new RepoTransfer();
             var managers = repositoryTransfer.GetManagers()
                .Where(m => (m.Id == id)).Select(m => (new Manager()
                {
                    Id = m.Id,
                    SecondName = m.SecondName
                })).ToArray();
             return PartialView("PartialManagersList", managers);
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