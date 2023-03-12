public class Menu
    {
        public Menu()
        {

        }

        public string MenuInput() //this gives you the menu options
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string input = Console.ReadLine();
            return input;
        }

        public string CreateGoal()
        {
            Console.WriteLine("The Types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goals");
            Console.WriteLine("  3. Checklist Goals");
            Console.Write("Which type of goal would you like to create? ");
            string input = Console.ReadLine();
            return input;
        }
        public void Quit()
        {
            Console.WriteLine("Thanks for playing, hope to see you soon!");
        }

    }