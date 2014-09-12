using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Social Security Number: ");
            string SSN = Console.ReadLine();
            Console.WriteLine("Enter hourly pay rate: ");
            double HPR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number hours worked: ");
            double NumberHoursWorked = Convert.ToDouble(Console.ReadLine());

            double GrossPay = HPR * NumberHoursWorked;
            double FWT = .15 * GrossPay;
            double SWT = .5 * GrossPay;
            double NetPay = GrossPay - (FWT + SWT);

            Console.WriteLine("\n\nPayroll summary for: " + name);
            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("You worked " + NumberHoursWorked + " hours at $" + HPR + " per hour.\n");
            Console.WriteLine("Gross pay: \t\t\t" + "$" + GrossPay);
            Console.WriteLine("Federal witholding: \t\t" + "$" + FWT);
            Console.WriteLine("State witholding: \t\t" + "$" + SWT);
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Net pay: \t\t\t" + "$" + NetPay);

            Console.ReadLine(); //keeps the console open 

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
