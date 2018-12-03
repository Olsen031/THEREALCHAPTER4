using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWindSpeed;
            double windSpeed;
            string category;

            Console.Write("Enter the wind speed here ---->");
            inputWindSpeed = Console.ReadLine();
            windSpeed = Convert.ToDouble(inputWindSpeed);

            if (windSpeed >= 157)
            {
                category = "Category 5 Hurricane";
            }
            else if (windSpeed < 157 && windSpeed >= 130)
            {
                category = "Category 4 Hurricane";
            }
            else if (windSpeed < 130 && windSpeed >= 111)
            {
                category = "Category 3 Hurricane";
            }
            else if (windSpeed < 111 && windSpeed >= 96)
            {
                category = "Category 2 Hurricane";
            }
            else if (windSpeed < 96 && windSpeed >= 74)
            {
                category = "Category 1 Hurricane";
            }
            else
                category = "Tropical Storm";

            Console.WriteLine("You entered {0} mph, which means the storm was a {1}", windSpeed, category);
        }
    }
}
