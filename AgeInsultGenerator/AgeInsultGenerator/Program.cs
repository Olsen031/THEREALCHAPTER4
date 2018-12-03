using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            string yesString;
            int yes;
            WriteLine("Enter your current age to get a special message about your age ----->");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);
            if(age < 18)
            {
                WriteLine("Damn, you are still young");
            }
            else if(age >= 18 && age <= 25)
            {
                WriteLine("You're starting to get up there, you're becoming an old fart.");
            }
            else if(age >= 26 && age <= 32)
            {

                WriteLine("Did you start a family yet, 1 for yes and 2 for no?");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if(yes == 1)
                {
                    WriteLine("Congradulations, I'm sure your baby really is cute");
                }
                else
                {
                    WriteLine("Just remember, no one will help you when you're old and fall down the stairs");
                }

            }
            else if(age > 32 && age <= 42)
            {
                WriteLine("I hope you have a solid career by now, and not still working at McDonalds making $8.50 an hour");
            }
            else if(age > 42 && age <= 52)
            {
                WriteLine("Retirement should be near, hope you have enough saved");
            }
            else if(age > 52 && age <= 62)
            {
                WriteLine("The end is near, enjoy the few remaining years you have of being able to sleep normal hour and " +
                    "being able to go up and down stairs");
            }
            else
            {
                WriteLine("You're still here, that's surprising, I'd thought you'd only make it to 51");
            }

        }
    }
}
