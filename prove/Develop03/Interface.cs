using System.IO;
public class Interface
    {
        public Scripture script = new Scripture();
        
        public Interface()
        {

        }

        public void clearScreen()
        {
            Console.Clear();
        }

        public Boolean askInput()
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string x = Console.ReadLine();
            if (x == "")
            {
                return true;
            }
            else if (x == "quit")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void display(List<String> scripture)
        {
            clearScreen();
            script.scriptureConstruct(scripture);
        }
    }