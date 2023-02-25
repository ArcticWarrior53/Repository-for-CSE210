using System.IO;
public class Exercises
    {
        //public Scripture proverbs = new Scripture();
        protected string _activityDescription;
        protected string _activity; 
        protected int _seconds;
        //protected DateTime _pauseTime;


        public Exercises()
        {

        }

        public void activityInitializer(string activity, string activityDescription) //this states the activity name and description.
        {
            Console.WriteLine($"Welcome to {activity}");
            Console.WriteLine();
            Console.WriteLine(activityDescription);
            Console.WriteLine();
        }

        public int askTime() // this asks for seconds
        {
            Console.WriteLine("How long, in seconds, would you like for your session to last?");
            _seconds = Int32.Parse(Console.ReadLine());
            return _seconds;
        }

        public void getReady() //this tells people to get ready.
        {
            Console.WriteLine("Get Ready...");
            loadingGraphic(6); // this pauses the program for 6 seconds.
            
        }

        public void completionMessage(int seconds) //this gives you the completion messages
        {
            Console.WriteLine("Well Done!");
            Console.WriteLine();
            loadingGraphic(6);
            Console.WriteLine($"You have completed another {seconds} seconds of {_activity}");
            loadingGraphic(6);
        }

        public void loadingGraphic(int time) //this displays the loading graphic.
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(time);
            //Thread.Sleep(time);
            do
            { //This does the loading graphic, it does 3 dots "..." then deletes it. 
                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write("\b\b \b");
                Thread.Sleep(500);
                Console.Write("\b\b \b");
                Thread.Sleep(500);
                Console.Write("\b\b \b");
                Thread.Sleep(500);
                startTime = DateTime.Now;
            } while(startTime < futureTime);
        }

        public void countDown(int time) //this provides the countdowns for all the stuff
        {
            int x = 1;
            Console.Write($"{time}");
            Thread.Sleep(700);
            while (x < time)
            {
                Console.Write("\b \b");
                Console.Write(time-x);
                Thread.Sleep(700);
                x++;
            }
            Console.WriteLine();
        }

    }