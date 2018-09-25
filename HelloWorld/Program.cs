using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please pick a number between 1 and 10: ");
            

            var rnd = new Random();
            var randomNumber = rnd.Next(1, 10);
            var win = false;
            var guessCounter = 0;
            while (false == win)
            {
                var userGuess = Console.ReadLine();
                int.TryParse(userGuess, out int x);

                if (x == 0)
                {
                    Console.Write("I said pick a number, try again: ");
                    continue;
                }
                if (x < 1)
                {
                    Console.Write("You picked a number lower than 1, please pick another: ");
                }
                else if (x > 10)
                {
                    Console.Write("You picked a number lower higher than 10, please pick another: ");
                }
                else if (x < randomNumber)
                {
                    Console.Write("You are too low, pick another number: ");
                    guessCounter++;
                }
                else if (x > randomNumber)
                {
                    Console.Write("You are too high, pick another number: ");
                    guessCounter++;
                }

                else
                {
                    Console.Write("Congratulations, you guessed correctly in {0} guesses", (guessCounter + 1));
                    win = true;
                    Console.ReadLine();
                }
            }
        }    
    }
}
