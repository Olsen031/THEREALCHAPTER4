using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        { 
            double purchase;
            string dollars;

            Console.Write("Enter the value of your purchase ---->");
            dollars = Console.ReadLine();
            purchase = Convert.ToDouble(dollars);

            if (purchase <= 5000)
            {
                Console.WriteLine("Approved");
            }
            else
                Console.WriteLine("Error");
        }
    }
}
