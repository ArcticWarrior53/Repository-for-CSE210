using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu(); //opens up the meny class
        string input = ""; //accepts input from menu
        Boolean done1 = false; //These booleans work with the completed function to track whether or not
        Boolean done2 = false; // You have earned a gold star.
        Boolean done3 = false;
        while (input != "4") //This loop contains the entire program.
        {
            Console.Clear();
            input = menu1.MenuInput(); //This opens up the menu
            if (input == "1") //This option runs the breathing exercise
            {
                Breathing breath = new Breathing();
                Console.Clear();
                string breathActivity = breath.name();
                string breathDescription = breath.description();
                breath.activityInitializer(breathActivity, breathDescription);
                int breathSeconds = breath.askTime();
                Console.Clear();
                breath.getReady();
                breath.breathLoop(breathSeconds);
                breath.completionMessage(breathSeconds);
                done1 = true;
                menu1.completed(done1,done2,done3);
            }
            else if (input == "2") //This option runs the listing exercise
            {
                Listing list = new Listing();
                Console.Clear();
                string listActivity = list.name();
                string listDescription = list.description();
                list.activityInitializer(listActivity, listDescription);
                int listSeconds = list.askTime();
                Console.Clear();
                list.getReady();
                list.prompt();
                list.listingActivity(listSeconds);
                list.completionMessage(listSeconds);
                done2 = true;
                menu1.completed(done1,done2,done3);
            }
            else if (input == "3") //this option opens the reflection exercise
            {
                Reflections reflec = new Reflections();
                Console.Clear();
                string reflecActivity = reflec.name();
                string reflecDescription = reflec.description();
                reflec.activityInitializer(reflecActivity, reflecDescription);
                int reflecSeconds = reflec.askTime();
                Console.Clear();
                reflec.getReady();
                reflec.promptMessage();
                reflec.ponderQuestions(reflecSeconds);
                reflec.completionMessage(reflecSeconds);
                done3 = true;
                menu1.completed(done1,done2,done3);
            }
            else if (input == "4") //this option exits the program.
            {
                Exercises exiting = new Exercises();
                Console.Clear();
                Console.WriteLine("Thanks for using this program!");
                Console.Write("Exiting");
                exiting.loadingGraphic(6);
            }
            else //this detects invalid inputs.
            {
                Exercises invalid = new Exercises();
                Console.WriteLine("Invalid Input. Please enter a number 1-4.");
                invalid.loadingGraphic(3);
            }
        }
    }
}