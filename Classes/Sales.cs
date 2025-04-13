using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butchershop.Classes
{
    internal class Sales
    {
       public int ID { get; set; }
       public int ProductID { get; set; }
        public int WeightSold { get; set; }
        public int TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
