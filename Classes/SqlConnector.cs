using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butchershop.Classes
{
    public class SqlConnector
    {
     private string server = "localhost";
     private string userid = "root";
     private string password = "vertrigo";
     private string database = "butchershop";
        public string GetConnect()
        {
            return $"server={server};userid={userid};password={password};database={database}";

        }
    }
      
}
