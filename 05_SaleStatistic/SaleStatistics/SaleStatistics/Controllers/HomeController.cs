using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaleStatistics.Models;
using BL;
using System.Web.Script.Serialization;

namespace SaleStatistics.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {

        // GET: HomePage
        [AllowAnonymous]
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
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
        public ActionResult ManagerEdit(Manager manager)
        {
            TryValidateModel(manager);
            if (ModelState.IsValid)
            {
                var repositoryTransfer = new RepoTransfer();
                var existManagerDTO = repositoryTransfer.GetManagers()
                    .FirstOrDefault(m => (m.SecondName == manager.SecondName));

                if (existManagerDTO == null)
                {
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


        public ActionResult ShowSManager(string saleManager)
        {
            var repositoryTransfer = new RepoTransfer();
            var sales = repositoryTransfer.GetSales()
               .Where(s => (s.Manager == saleManager))
               .Select(m => (new SaleInfo()
               {
                   Id = m.Id,
                   Date = m.Date,
                   Manager = m.Manager,
                   Client = m.Client,
                   Product = m.Product,
                   PriceSum = m.PriceSum
               })).ToArray();
            return PartialView("PartialSalesList", sales);
        }

        public ActionResult ShowSClient(string saleClient)
        {
            var repositoryTransfer = new RepoTransfer();
            var sales = repositoryTransfer.GetSales()
               .Where(s => (s.Client == saleClient))
               .Select(m => (new SaleInfo()
               {
                   Id = m.Id,
                   Date = m.Date,
                   Manager = m.Manager,
                   Client = m.Client,
                   Product = m.Product,
                   PriceSum = m.PriceSum
               })).ToArray();
            return PartialView("PartialSalesList", sales);
        }

        public ActionResult ShowSProduct(string saleProduct)
        {
            var repositoryTransfer = new RepoTransfer();
            var sales = repositoryTransfer.GetSales()
               .Where(s => (s.Product == saleProduct))
               .Select(m => (new SaleInfo()
               {
                   Id = m.Id,
                   Date = m.Date,
                   Manager = m.Manager,
                   Client = m.Client,
                   Product = m.Product,
                   PriceSum = m.PriceSum
               })).ToArray();
            return PartialView("PartialSalesList", sales);
        }

        public ActionResult ShowSDate(DateTime saleDate)
        {
            var repositoryTransfer = new RepoTransfer();
            var sales = repositoryTransfer.GetSales()
               .Where(s => (s.Date == saleDate))
               .Select(s => (new SaleInfo()
               {
                   Id = s.Id,
                   Date = s.Date,
                   Manager = s.Manager,
                   Client = s.Client,
                   Product = s.Product,
                   PriceSum = s.PriceSum
               })).ToArray();
            return PartialView("PartialSalesList", sales);
        }

        //[HttpGet]
        //public JsonResult GetManagersChartData()
        //{
        //    var repositoryTransfer = new RepoTransfer();
        //    var sales = repositoryTransfer.GetSales()
        //                                  .GroupBy(s => s.Manager)
        //                                  .Select(m => new object[] { m.Key, m.Sum(x => x.PriceSum) })
        //                                  .ToArray();
        //    return Json(sales, JsonRequestBehavior.AllowGet); //The value of the transfer: AllowGet - Enable get request

        //}


        [HttpGet]
        public JsonResult GetManagersChartData()
        {
            List<ChartModel> sales = new List<ChartModel>
           {
              new ChartModel { ManagerName = "TomTailor", PriceSum = 28 },
              new ChartModel { ManagerName = "Tom", PriceSum = 8 },
              new ChartModel { ManagerName = "Tailor", PriceSum = 2 }
           };
            return Json(sales, JsonRequestBehavior.AllowGet); //The value of the transfer: AllowGet - Enable get request

        }

        private List<ChartModel> GetUsers()
        {
            var usersList = new List<ChartModel>
            {
                new ChartModel
                {
                    ManagerName = "Ram",
                    PriceSum = 2
                },
                new ChartModel
                {
                    ManagerName = "chand",
                    PriceSum = 33
                },
                new ChartModel
                {
                    ManagerName = "Abc",
                    PriceSum = 4
                }
            };

            return usersList;
        }


        [AllowAnonymous]
        [HttpGet]
        public JsonResult GetUsersData()
        {
            var users = GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        //test
        public ActionResult ViewChart()
        {
            GetUsersData();
            return View();
        }



        public ActionResult ManagersChart()
        {
            return View();
        }
    }
}