using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa, testScore;
            string inputGpa, inputTestScore;

            Console.Write("Enter your current GPA ---->");
            inputGpa = Console.ReadLine();
            Console.Write("Enter your admission test score ---->");
            inputTestScore = Console.ReadLine();
            gpa = Convert.ToDouble(inputGpa);
            testScore = Convert.ToDouble(inputTestScore);

            if ((gpa >= 3 && testScore >= 60) || (gpa <= 30 && testScore >= 80))
            {
                Console.WriteLine("You have been accepted!");
            }
            else
                Console.WriteLine("Rejected, have a nice life working at McDonalds");
        }
    }
}
