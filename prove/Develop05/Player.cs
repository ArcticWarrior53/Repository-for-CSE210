public class Player
{
    public List<Goal> _goals = new List<Goal>();
    public string _username;
    public int _level;
    //private Goal display = new Goal();
    Experience xp = new Experience();

    public void login()
    {
        Console.Write("Have you use eternal quest before? (yes/no) ");
        string ifyes = Console.ReadLine();
        if (ifyes.ToLower() == "yes")
        {
            Console.Write("Excellent, you can pick up where you left off. What is your name? ");
            _username = Console.ReadLine();
            LoadGoals();
        }
        else
        {
            Console.Write("Welcome! What is your name? ");
            _username = Console.ReadLine();
            _level = 0;
        }
        Console.WriteLine($"Welcome {_username} to Eternal Quest!");
    }
    void levelup()
    {
        
        int levelActual = xp._XPbar/100;
        if (levelActual > _level)
        {
            _level = levelActual;
            Console.WriteLine($"Congratulations on leveling up! you are now level {_level}");
        }
    }
    public void ExperienceBar(int x=0)
    {
        Console.WriteLine($"You are level {_level}");
        Console.WriteLine("Experience till next level: ");
        Console.Write("    |");
        int ten = 0;
        while (x < 10)
        {
            x++;
            ten += 10;
            if (ten < xp._XPbar-_level*100)
            {
                Console.Write("--");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine("|");
    }

     public void listGoals(int x=0)
        {
            foreach (Goal y in _goals)
            {
                Console.Write($"{x+1}. ");
                y.DisplayGoal(x);
                x++;
            }
        }

    public string CreateTitle()
        {
            Console.WriteLine("What is the name of your goal? ");
            string title = Console.ReadLine();
            return title;
        }
        public string CreateDescription()
        {
            Console.Write("What is short description? ");
            string title = Console.ReadLine();
            return title;
        }
        public int CreatePoints()
        {
            Console.Write("How many points is your goal worth? ");
            int pointValue = Int32.Parse(Console.ReadLine());
            return pointValue;
        }
        public int CreateTotal()
        {
            Console.Write("How many times do you need to complete till you get a bonus? ");
            int totalTo = Int32.Parse(Console.ReadLine());
            return totalTo;
        }
        public int CreateBonus()
        {
            Console.Write("How many points is the bonus worth? ");
            int bonus = Int32.Parse(Console.ReadLine());
            return bonus;
        }
        public void SaveGoals()
        {
            //Saves goals and player data into a file
            using (StreamWriter file = new StreamWriter($"{_username}.txt"))
            {
            file.WriteLine($"{_username}//{xp._XPbar}");
            foreach (Goal x in _goals){
                file.WriteLine(x.GetInfo());
            }
        }
        }
        
        public void LoadGoals()
    {
        // a line in the file would look like this:
        // goalType//title//description//pointValue//iscompleted
        // alternatively, for checklist goals:
        // goalType//title//description//pointValue/timesToComplete//bonus//timesCompleted
        string filename = _username;
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("//");
            string goalType = parts[0];
            if (goalType.ToLower() == "checklist")
            {
                string title = parts[1];
                string description = parts[2];
                int pointValue = Int32.Parse(parts[3]);
                int timesToComplete = Int32.Parse(parts[5]);
                int bonus = Int32.Parse(parts[4]);
                int timesCompleted = Int32.Parse(parts[6]);
                _goals.Add(new Checklist(title,description,pointValue, timesToComplete, bonus, timesCompleted));

            }
            else if (goalType.ToLower() == "simple")
            {
                string title = parts[1];
                string description = parts[2];
                int pointValue = Int32.Parse(parts[3]);
                bool isCompleted = Boolean.Parse(parts[4]);
                _goals.Add(new Simple(title,description,pointValue, isCompleted));
            }
            else if (goalType.ToLower() == "eternal")
            {
                string title = parts[1];
                string description = parts[2];
                int pointValue = Int32.Parse(parts[3]);
                _goals.Add(new Eternal(title,description,pointValue));
            }
            else if (goalType.ToLower() == _username.ToLower())
            {
                xp._XPbar = Int32.Parse(parts[1]);
                _level = xp._XPbar / 100;
            }

            
            
            //_goals.Add(parts);
        }
    }
        
        public void RecordEvent()
        {
            listGoals();
            Console.Write("Which goal did you accomplish? ");
            int done = int.Parse(Console.ReadLine()) - 1;
            xp._XPbar += _goals[done].Record();
            levelup();
        }

}