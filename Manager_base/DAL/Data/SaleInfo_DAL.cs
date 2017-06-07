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
        public int ClientId { get; set; }
        public int ManagerId { get; set; }
        public int ProductId { get; set; }
        public double PriceSum { get; set; }
    }
}
