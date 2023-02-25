using System.IO;
public class Reflections : Exercises
    {
        private List<string> _prompts = new List<string>() {"you did something really difficult.", "having faith was difficult.", "you learned through failure.", "you showed kindness.", "you were trusted to do something hard.", "showed love."};
        private string _input; 

//THis is the only one I've gotten mostly done aside from meny and exercises. 
        public Reflections()
        {

        }

        public string name() //this makes it so it prints out the right name
        {
            _activity = "Reflection Activity";
            return _activity;
           
        }

        public string description() //this gives it the proper description
        {
            _activityDescription = "This activity will help you reflect on times in your life when you showed strength and resilience. This will help you to recognize the power you have and how you can use it in other aspects of your life.";
            return _activityDescription;
        }

        public string promptMessage() //this gives the prompt for the relfection.
        {
            Random randomGenerator = new Random();
            int promptIndex = randomGenerator.Next(0, 5);
            string promptText = _prompts[promptIndex];
            Console.WriteLine($" --- Think of a time when {promptText} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            do
            {
                _input = Console.ReadLine();
            } while (_input != "");
            return _input;
            
        }

        public void ponderQuestions(int seconds) //This function asks the questions.
        {
            List<string> questions = new List<string>() {" > How did you feel when it was finished? ", " > What was your favorite thing about the experience? ", " > What made the experience difficult? ", " > How can you apply what you learned in that experience elsewhere in your life?"};
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);
            int x = 0;
            while (startTime < futureTime)
            {
                Console.WriteLine(questions[x]);
                loadingGraphic(8);
                x++;
                startTime = DateTime.Now;
            }
        } 
    }