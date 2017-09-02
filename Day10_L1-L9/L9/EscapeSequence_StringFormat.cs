using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_L1_L9.L9
{
    class EscapeSequence_StringFormat
    {
        public void ShowEsSf()
        {
            string s0 = "Go c:\\ drive. ";
            string s1 = "My \"so called\" Life. ";
            string s2 = String.Format("Make {0} -- Model: {1}.", "BMW", "Model001");
            Console.WriteLine(s0+s1+s2);

            string s3 = String.Format("Money is: {0:C} -- ", 123.45);
            string s4 = String.Format("Number with Spearator: {0:N} -- ", 1234456789);
            string s5 = String.Format("Percentage: {0:P} -- ", .127);
            DateTime theDate = new DateTime(2009, 10, 7);
            string s6 = String.Format("Month: {0:00} -- ", theDate.Month);
            string s7 = String.Format("\nPhone Number: {0:(###) ###-####}", 123456789001);
            Console.WriteLine(s3+s4+s5+s6+s7);
        }
    }
}
