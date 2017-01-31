using MathMagician.Numbers;
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
            Console.WriteLine(" 1. Natural numbers" + Environment.NewLine + " 2. Even numbers" + Environment.NewLine + " 3. Odd numbers" + Environment.NewLine + " 4. Fibonacci numbers");
            // Think about, 'How will the user pick a command?'
            //Is it better to modify the original question? Make it more useful

            string Command = Console.ReadLine();
            int userCommand = Int32.Parse(Command);

            Console.WriteLine("How many should I print?");
            string howMany = Console.ReadLine();
            int amountOfNumbers = Int32.Parse(howMany);

            if(amountOfNumbers <= 30)
            {
                if(userCommand == 1)
                {
                    Console.WriteLine($"Neat, I'm going to print {amountOfNumbers} natural integers.");

                    NaturalNumber naturalNumber = new NaturalNumber();

                    int[] numbersToPrint = naturalNumber.GetSequence(amountOfNumbers);

                    Console.WriteLine(naturalNumber.PrintNumbers(numbersToPrint));
                }
                else if(userCommand == 2)
                {
                    Console.WriteLine($"Neat I'm going to print {amountOfNumbers} Even numbers");

                    Even evenNumber = new Even();

                    int[] numbersToPrint = evenNumber.GetSequence(amountOfNumbers);

                    Console.WriteLine(evenNumber.PrintNumbers(numbersToPrint));

                }
                else if(userCommand == 3)
                {
                    Console.WriteLine($"Neat I'm going to print {amountOfNumbers} Odd numbers");

                    Odd oddNumber = new Odd();

                    int[] numbersToPrint = oddNumber.GetSequence(amountOfNumbers);

                    Console.WriteLine(oddNumber.PrintNumbers(numbersToPrint));
                }
                else if(userCommand == 4)
                {
                    Console.WriteLine($"Neat I'm going to print {amountOfNumbers} Fibonacci numbers");

                    Fibonacci fibNumber = new Fibonacci();

                    int[] numbersToPrint = fibNumber.GetSequence(amountOfNumbers);

                    Console.WriteLine(fibNumber.PrintNumbers(numbersToPrint));
                }
                else
                {
                    Console.WriteLine("You didnt select a correct option!");
                }
            }
            else
            {
                Environment.Exit(0);
            }

            //Okay!! Print some stuff!!

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
