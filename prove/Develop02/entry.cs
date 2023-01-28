public class Entry
    {
        public string _entry;
        public string[] _prompts = {"If I had one thing I could do over today, what would it be?", "What was the best part of my day?", "What are you grateful for today?", "What did you eat?","What was your favorite thing to do today?", "What can you do better tomorrow?"};
       public string createEntry()
       {
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, 5);
        Console.WriteLine(_prompts[promptIndex]);
        Console.Write("> ");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _entry = "Date: " + dateText + " - Prompt: " + _prompts[promptIndex] + "\n" + Console.ReadLine();
        return _entry;       
       }
       
       public void displayEntry()
       {
        Console.WriteLine(_entry);
       }
    }