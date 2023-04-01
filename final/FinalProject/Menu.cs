public class Menu
    {
        public Menu()
        {

        }

        public int MenuInput() //this gives you the menu options
        {
            Console.WriteLine("Choose an Archetype:");
            Console.WriteLine(" 1 - Spellcaster");
            Console.WriteLine(" 2 - Warrior");
            Console.WriteLine(" 3 - Mastermind");
            Console.WriteLine(" 4 - Monster");
            Console.Write("Input: ");
            int input = Int32.Parse(Console.ReadLine());
            return input;
        }

    }