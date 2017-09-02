using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_L1_L9.First4lectures
{
    class L1_L4
    {
        public static void ShowL1ToL4()
        {
            Day10Entities_Model dem = new Day10Entities_Model();
            var d0 = from a in dem.Customers
                     where a.Orders.Any( b => b.OrderPrice > 300 ) && a.Gender == "Female"
                     select a;
            foreach (var o in d0)
            {
                Console.WriteLine("19 -- FirstName: {0} -- Gender: {1}.", o.FirstName, o.Gender);
            }

            var d1 = dem.Customers.Where(p => p.Orders.Any(q => q.OrderPrice > 500)).Select(b => b.LastName);
            foreach (var i in d1)
            {
                Console.WriteLine("\n25 -- LastName: {0}.", i);
            }

            var d2 = dem.Customers.Select(p => new { p.FirstName, p.LastName });
            foreach (var i in d2)
            {
                Console.WriteLine("\n25 -- LastName: {0} -- FirstName: {1}.", i.LastName, i.FirstName);
            }

            var d3 = dem.Customers.Where(b => b.State == "Colorado" && b.Gender == "Female").Select(c => new { c.LastName, PurchaseOrders = c.Orders });
            foreach (var o in d3)
            {
                Console.WriteLine("LastName: {0} -- Order Count: {1}.", o.LastName, o.PurchaseOrders.Count);
            }

            //var d4 = dem.Customers.FirstOrDefault(p => p.Gender == "Female" && p.Orders.Any(x => x.OrderPrice > 10));
            //Console.WriteLine("\n41 -- LastName: {0} -- State: {1}", d4.LastName, d4.State);
        }
    }
}
