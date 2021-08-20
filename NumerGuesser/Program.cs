using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            
            while (true) { 

            //   int correctNumber = 7;'

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int guessNumber = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guessNumber != correctNumber)
            {
                string input = Console.ReadLine();


                if (!int.TryParse(input, out guessNumber)) {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actaul number....");
                    continue;

                }


                guessNumber = Int32.Parse(input);
                if (guessNumber != correctNumber) {
                        PrintColorMessage(ConsoleColor.Red, "Wrong !!!");
                    }

            }

                PrintColorMessage(ConsoleColor.Yellow, "Awesome..You are correct !");
            //Ask User if they want to play again

            Console.WriteLine("Wanna Play again ? [Y or N]");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                continue;
            }
            else if (answer == "N") {
                    break;
                }
                else
                {
                    return;
                }

        } }

        private static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Abhay singh";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

        }

        private static void GreetUser()
        {
            Console.WriteLine("What is your name : ");
            string inputName = Console.ReadLine();
            Console.WriteLine("hey {0}, let's play a game...", inputName);

        }

        private static void PrintColorMessage(ConsoleColor color, String message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
