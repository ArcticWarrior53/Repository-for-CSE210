using System;

class Program
{
    static void Main(string[] args)
    {
        //These collect input, the first prompt will be replaced later.
        Random randomGenerator = new Random();
        int mNum = randomGenerator.Next(1, 100);
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string uinput = Console.ReadLine();
            //This turns the input into numbers so I can work with them
            guess = int.Parse(uinput);
            //This checks the guess to see if it is higher, lower, or matches the magic number.
            if (guess > mNum)
            {  
                Console.WriteLine("Lower");
            }
            else if (guess < mNum)
            {  
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while(guess != mNum);
    }
}