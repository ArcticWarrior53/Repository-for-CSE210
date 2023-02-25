using System.IO;
public class Breathing : Exercises
    { 



        public Breathing()
        {

        }

        public string name() //this makes it so it prints out the right name
        {
            _activity = "Breathing Activity";
            return _activity;
           
        }

        public string description() //this gives it the proper description
        {
            _activityDescription = "This activty will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            return _activityDescription;
        }

        public void breathLoop(int seconds) //this does the breathing in and out
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);
            Console.Write("Breath in...");
            countDown(3);
            Console.Write("Now Breath out...");
            countDown(3);
            while(startTime < futureTime)
            {
                Console.WriteLine();
                Console.Write("Breath in...");
                countDown(4);
                Console.Write("Now Breath out...");
                countDown(6);
                startTime = DateTime.Now;
            }
        }

    }