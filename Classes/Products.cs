using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butchershop.Classes
{
    public class Products
    {
     public int ID { get; set; }

     public string Name { get; set; }
     public string Category { get; set; }
     public int PricePerKg { get; set; }
     public int StockWeight { get; set; }
     public DateTime ArrivalDate { get; set; } 
    }
}
