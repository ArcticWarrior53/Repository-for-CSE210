using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                string activityTime = Console.ReadLine();
                int time = int.Parse(activityTime);
                Console.WriteLine(time);
    }
}