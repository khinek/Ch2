using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, SSM, double HPR, int NumberHoursWorked // input variables
            double GrossPay = HPR * NumberHoursWorked, FWT = .15 * GrossPay, SWT = .5 * GrossPay, NetPay = GrossPay - (FWT + SWT) //calculating variables;
            string input;
            
            double PayRate;

            Console.Write("Enter a double: ");
            input = Console.ReadLine();
            PayRate = Convert.ToDouble(input);




            /*
            bool success = double.TryParse(Console.ReadLine(), out PayRate);

            if (success)
            {
                // We have a legit number!!!!!

            }
            */
        }
    }
}
