using System;

class Program
{
    static void Main(string[] args)
    {
        Interface inter = new Interface();
        Memorize mem = new Memorize();
        Scripture script = new Scripture();
        Boolean input = true;
        List<string> scripture = script.passCopy();
        do
        {
            inter.display(scripture);
            input = inter.askInput();
            Random randomGen = new Random();
            int numTimes = randomGen.Next(1, 3); 
            for (int x = 0; x <= numTimes; x++)
            {
                scripture = mem.removeWords();
            }
        } while (input != false);
    }
}