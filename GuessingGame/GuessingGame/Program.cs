using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);
            string inputUserGuess;
            int userGuess;

            Console.Write("Please enter a guess that ranges from 1 to 10 ---->");
            inputUserGuess = Console.ReadLine();
            userGuess = Convert.ToInt32(inputUserGuess);

            Console.WriteLine("The random number was " + randomNumber);
            if (userGuess > randomNumber)
                Console.WriteLine("The integer you entered was too high");
            else if (userGuess < randomNumber)
                Console.WriteLine("The integer you entered was too low");
            else if (userGuess == randomNumber)
                Console.WriteLine("You guessed the correct integer");
            else
                Console.WriteLine("You entered an invalid integer dummy");



        }
    }
}
