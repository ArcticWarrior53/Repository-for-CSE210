public class BadGuy
{
    protected string _name;
    protected List<string> _abilities = new List<string>(); 
    protected string _ancestry; 
    protected List<string> _gear = new List<string>();
    protected List<string> _goals = new List<string>(); 
    protected List<string> _minions = new List<string>();
    protected string _visualDescription;
    protected string _lair;
    protected int _number;
    protected List<string> _names;

    public int _health;
    public int _strength;
    public int _smarts;

    public List<String> _ArchetypeAbilities;
    public List<String> _ArchetypeMinions;

    public List<string> RandomAbilities(int abLength, int numAb, List<string> abList)
    {
        Random randomGenerator = new Random();
        List<string> results = new List<string>();
        for (int i=0; i < numAb; i++)
        {
            int _number = randomGenerator.Next(0, abLength);
            string ability = abList[_number];
            results.Add(ability);
        }
        return results;
    }
    public string ancestryPrompt() //give options for an ancestry
    {
        Ancestries BadAncestor = new Ancestries();
        int ancesNum = BadAncestor.ancestryOptions();
        _ancestry = BadAncestor.setAncestry(ancesNum);
        List<string> addAncesAbil = BadAncestor.addAbilities(ancesNum);
        for (int i=0; i < addAncesAbil.Count(); i++)
        {
            _abilities.Add(addAncesAbil[i]);
        } 
        Console.WriteLine($"You chose {_ancestry}! Good Choice");
        return _ancestry;

    }
    public virtual string namePrompt() //– remember to include an option for input if they don’t like the options
    {
        Random randName = new Random();
        int nameOne = randName.Next(0, 6);
        int nameTwo;
        int nameThree;
        if (nameOne != 0)
        {
            nameTwo = nameOne - 1;
            nameThree = nameOne +1;
        }
        else if (nameOne == 11)
        {
            nameTwo = nameOne -1;
            nameThree = nameOne -2;
        }
        else
        {
            nameTwo = nameOne +1;
            nameThree = nameOne +2;
        }
        Console.WriteLine("The options for the name are:");
        Console.WriteLine($"      1. {_names[nameOne]}");
        Console.WriteLine($"      2. {_names[nameTwo]}");
        Console.WriteLine($"      3. {_names[nameThree]}"); 
        Console.WriteLine("Choose One option, or enter a different name:");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            return _names[nameOne];
        }
        else if (choice == "2")
        {
            return _names[nameTwo];
        }
        else if (choice == "3")
        {
            return _names[nameThree];
        }
        else
        {
            return choice;
        }

    }
    public List<String> abilitiesPrompt() //randomly generates abilities and the user selects half
    {
        Console.WriteLine("Abilities options:");
        List<string> results = RandomAbilities(10, 6, _ArchetypeAbilities);
        for (int x=0; x < 6; x++)
        {
            Console.WriteLine($"   {x+1}. {results[x]}");
        }
        for (int i=0; i < 3; i++)
        {
            Console.WriteLine($"Choose 3 abilities. ({i}/3 abilities chosen):");
            int ability = Int32.Parse(Console.ReadLine()) - 1;
            _abilities.Add(results[ability]);
        }
        return _abilities;

    }
    public virtual List<string> gearPrompt() //randomly generates magical items, has the option to input items as well
    {
        Console.WriteLine("Enter the gear your bad guy has");
        string gear = Console.ReadLine();
        if (gear != "")
        {
            _gear.Add(gear);
        }
        return _gear;
    }
    public virtual List<string> minionsPrompt() //randomly generates minions and adds to list
    {
        Console.WriteLine("Enter the name of your minion");
        string minion = Console.ReadLine();
        _minions.Add(minion);
        return _minions;

    }
    public virtual string lairPrompt() //acts for a description of the lair
    {
        Console.WriteLine("What kind of lair or secret base do they have?");
        _lair = Console.ReadLine();
        return _lair;
    }
    public virtual List<string> goalsPrompt()
    {
        Console.WriteLine("Now that you know their capabilities, what are their goals? Is it Revenge? maybe overthrowing the King?");
        Console.WriteLine("Type 'exit' when you are ready to quit.");
        string input;
        do 
        {
            input = Console.ReadLine();

        } while (input.ToLower() != "exit");
        string goals = Console.ReadLine();
        _goals.Add(goals);
        return _goals;
    }
    public virtual string descriptionPrompt() //– this will give them ideas, rather than a full appearance, they will write the description themselves
    {
        Console.WriteLine("Enter the description of your bad guy");
        _visualDescription = Console.ReadLine();
        return _visualDescription;

    }

    public string SetStats(int stat)
    {
        string statString;
        if (stat <= 0)
        {
            statString = "Very Low";
        }
        else if (stat == 1)
        {
            statString = "Low";
        }
        else if (stat == 2)
        {
            statString = "Middling";
        }
        else if (stat == 3)
        {
            statString = "High";
        }
        else if (stat == 4)
        {
            statString = "Very High";
        }
        else if (stat == 5)
        {
            statString = "Extremely High";
        }
        else
        {
            statString = "Exceptionally High";
        }
        return statString;
    }


}