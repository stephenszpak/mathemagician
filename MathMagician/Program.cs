using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a type of number.");
            Console.WriteLine(" 1. Natural numbers" + Environment.NewLine + " 2. Prime numbers" + Environment.NewLine + " 3. Fibonacci numbers" + Environment.NewLine + " 4. Even numbers" + Environment.NewLine + " 5. Odd numbers"); //"How" you provide the user useful info is on you.
            // Think about, 'How will the user pick a command?'
            //Is it better to modify the original question? Make it more useful

            string Command = Console.ReadLine();
            //Once i have a command (whatever it looks like), how do i check if its a valid command?

            //When should you actually create an instance of your number class>
            Console.WriteLine("How many should I print?");

            string HowMany = Console.ReadLine();
            //when do i check if the "how many" response is too big?
            // if they enter a number > 30, how do i respond and exit the program?

            Console.WriteLine($"Cool, I'm going to print {Command} {HowMany}");

            //Okay!! Print some stuff!!

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
