using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
        Journal myJournal = new Journal();
        Entry myEntry = new Entry();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1 - Write new Entry");
            Console.WriteLine("2 - Display entries");
            Console.WriteLine("3 - Save to file");
            Console.WriteLine("4 - Load from file");
            Console.WriteLine("5 - Exit");
            Console.Write("What would you like to do? ");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                string newEntry = myEntry.createEntry();
                myJournal.addEntry(newEntry);
            }
            else if (input == 2)
            {
                myJournal.displayEntry();
            }
            else if (input == 3)
            {
                myJournal.saveJournal();
            }
            else if (input == 4)
            {
                myJournal.loadJournal();
            }
            else if (input == 5)
            {
                Console.WriteLine("See you tomorrow!");
            }
            else
            {
            Console.WriteLine("I'm sorry, that's an invalid input. Enter a number between 1 and 5");
            }
        } while (input != 5);
    }
}