using System.IO;
public class Menu
    {
       



        public Menu()
        {

        }

        public string MenuInput() //this gives you the menu options
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start listing activity");
            Console.WriteLine("  3. Start reflection activity");
            Console.WriteLine("  4. Exit the Program");
            Console.WriteLine("Select a choice from the menu:");
            string input = Console.ReadLine();
            return input;
        }

        public void completed(Boolean done1, Boolean done2, Boolean done3)
        {
            if (done1 == true && done2 == true && done3 == true)
            {
                Console.WriteLine("Congratulations! You have completed all three mindfullness activities!");
                Console.WriteLine("You get a gold star!");
                Console.WriteLine("*       *      *");
                Console.WriteLine("*    *     *    *");
                Console.WriteLine("*     *   *     *");
                Thread.Sleep(5000);
            }
            else if (done1 == true && done2 != true && done3 != true)
            {
                Console.WriteLine("You have two more activties to go!");
                Thread.Sleep(3000);
            }
            else if (done1 != true && done2 == true && done3 != true)
            {
                Console.WriteLine("You have two more activties to go!");
                Thread.Sleep(3000);
            }
            else if (done1 != true && done2 != true && done3 == true)
            {
                Console.WriteLine("You have two more activties to go!");
                Thread.Sleep(3000);
            }
            else if (done1 == true && done2 == true && done3 != true)
            {
                Console.WriteLine("You have one more activty to go!");
                Thread.Sleep(3000);
            }
            else if (done1 == true && done2 != true && done3 == true)
            {
                Console.WriteLine("You have one more activty to go!");
                Thread.Sleep(3000);
            }
            else if (done1 != true && done2 == true && done3 == true)
            {
                Console.WriteLine("You have one more activty to go!");
                Thread.Sleep(3000);
            }
        }

    }