using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class SaleInfo_DAL
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ClientId { get; set; }
        public string ManagerId { get; set; }
        public string ProductId { get; set; }
        public double PriceSum { get; set; }
    }
}
