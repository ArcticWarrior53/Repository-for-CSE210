using System.IO;
public class Listing : Exercises
    {
        private List<string> _prompts = new List<string>() {"When have you felt the Holy Ghost this Month?", "How have you serced others this week?", "How did you make somone smile this month?", "What hymns have you sung this week?", "How have you been kind to your family?", "What will I do next week to be better?"};
        private string _input;



        public Listing()
        {

        }

        public string name() //this makes it so it prints out the right name
        {
            _activity = "Listing Activity";
            return _activity;
           
        }

        public string description() //this gives it the proper description
        {
            _activityDescription = "This activty will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            return _activityDescription;
        }
        
        public void prompt() // this gives you the prompt for the listing activity.
        {
            Random randomGenerator = new Random();
            int promptIndex = randomGenerator.Next(0, 5);
            string promptText = _prompts[promptIndex];
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {promptText} ---");
            Console.WriteLine("You may begin in: ");   
            countDown(5);
        }

        public void listingActivity(int seconds) //this lets you list things and then counts how many things you listed and tells you.
        {
            List<string> listedItems = new List<String>() {};
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);
            while (startTime < futureTime)
            {
                Console.Write("> ");
                _input = Console.ReadLine();
                listedItems.Add(_input);
                startTime = DateTime.Now;
            }
            int number = listedItems.Count();
            Console.WriteLine($"You listed {number} items.");
        }

    }