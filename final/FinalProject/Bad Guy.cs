public class BadGuy
{
    private string _name;
    List<string> _abilities; 
    string _ancestry; 
     List<string> _gear;
     List<string> _goals; 
     List<string> _minions;
     string _visualDescription;
     string _lair;
    public virtual string ancestryPrompt() //give options for an ancestry
    {
        Console.WriteLine("Enter the ancestry you want");
        _ancestry = Console.ReadLine();
        return _ancestry;

    }
    public virtual string namePrompt() //– remember to include an option for input if they don’t like the options
    {
        Console.WriteLine("Enter the name of your bad guy");
        _name = Console.ReadLine();
        return _name;

    }
    public virtual List<String> abilitiesPrompt() //randomly generates abilities and teh user selects half
    {
        Console.WriteLine("Enter the ability you want");
        string ability = Console.ReadLine();
        _abilities.Add(ability);
        return _abilities;

    }
    public virtual List<string> gearPrompt() //randomly generates magical items, has the option to input items as well
    {
        Console.WriteLine("Enter the gear your bad guy has");
        string gear = Console.ReadLine();
        _gear.Add(gear);
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
        Console.WriteLine("Enter the description of your lair");
        _lair = Console.ReadLine();
        return _lair;
    }
    public virtual List<string> goalsPrompt()
    {
        Console.WriteLine("Enter your goals");
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


}