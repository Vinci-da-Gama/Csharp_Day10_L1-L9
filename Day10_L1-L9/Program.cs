using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day10_L1_L9.First4lectures;
using Day10_L1_L9.FromStoreProcedure;
using Day10_L1_L9.L9;

namespace Day10_L1_L9
{
    class Program
    {
        static void Main(string[] args)
        {
            L1_L4.ShowL1ToL4();

            Day10Entities_Model dem = new Day10Entities_Model();
            var cust0 = (from cu in dem.Customers
                         where cu.CustomerId == 1
                         select cu).FirstOrDefault();
            if(cust0 != null)
            {
                cust0.FirstName = "hoho";
                cust0.State = "District_51";

                dem.SaveChanges();
            }

            var c0 = dem.Customers.Where(p => p.State == "District_51");
            foreach (var i in c0)
            {
                Console.WriteLine("FirstName: {0}.", i.FirstName);
            }

            #region Add_New_Customer
            Random rn = new Random();
            string rnStr = rn.Next(1, 100).ToString();
            Customer cu0 = new Customer()
            {
                FirstName = "fn0",
                LastName = "ln0",
                Email = "hohoho@haha.com",
                Gender = "Female",
                State = "District_"+ rnStr,
                CreditLimit = 123
            };

            dem.Customers.Add(cu0);
            dem.SaveChanges();

            var TheCust = dem.Customers.Where(p=> p.FirstName == "fn0" && p.LastName == "ln0");
            foreach (var i in TheCust)
            {
                Console.WriteLine("\n51 -- CreditLimit: {0}.", i.CreditLimit);
            }
            #endregion

            #region Delete_CustomerId_2
            Customer custWithId2 = (from a in dem.Customers
                               where a.CustomerId == 2
                               select a).FirstOrDefault();

            if ( custWithId2 != null )
            {
                var ol = dem.Orders.ToList();
                foreach (var o in ol)
                {
                    dem.Orders.Remove(o);
                }
                dem.Customers.Remove(custWithId2);
            }

            dem.SaveChanges();


            Customer custExists = (from a in dem.Customers
                                    where a.CustomerId == 2
                                    select a).FirstOrDefault();
            if (custExists != null)
            {
                Console.WriteLine("This customer suppose to be deleted.");
            }
            else
            {
                Console.WriteLine("Customer has been deleted.");
            }
            #endregion

            Store_Procedure_Data spd = new Store_Procedure_Data();
            spd.ShowSpData();

            EscapeSequence_StringFormat es = new EscapeSequence_StringFormat();
            es.ShowEsSf();

            Console.ReadLine();
        }
    }
}
