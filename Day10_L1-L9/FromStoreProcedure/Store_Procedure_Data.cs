using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_L1_L9.FromStoreProcedure
{
    class Store_Procedure_Data
    {
        public void ShowSpData()
        {
            Day10Entities_Model dem = new Day10Entities_Model();

            var AllCustomers = dem.GetCustomers();
            foreach (var i in AllCustomers)
            {
                Console.WriteLine("\n18 -- Email: {0}", i.Email);
            }

            var CustByState = dem.GetCustomerByState0("District_51");
            foreach (var o in CustByState)
            {
                Console.WriteLine("\n24 -- FirstName: {0}", o.FirstName);
            }
        }
    }
}
