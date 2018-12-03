using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string numPickString;
            int numPick;
            Console.Write("Please pick a number between 1 and 3 ----->  ");
            numPickString = Console.ReadLine();
            numPick = Convert.ToInt32(numPickString);

            if(numPick == 2)
            {
                Console.WriteLine("You entered 2, you win!");
            }
            else if (numPick == 1 || numPick == 3)
            {
                Console.WriteLine("You picked a 1 or a 3, you are a loser!");
            }
            else
            {
                Console.WriteLine("You did not choose a vaild number, therefore you are the biggest looser!!!");
            }


        }
    }
}
