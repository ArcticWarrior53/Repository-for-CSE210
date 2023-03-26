public class RecordSheet
{
    public void CreateRecordSheet(string name, string ancestry, List<String> abilities, List<String> gear, 
    List<string> minions, string lair, string visualDescription, string archetype, string health, string strength, string smarts)
    {
        //int times = abilities.Count();
        Console.WriteLine($"{name}");
        Console.WriteLine($"Ancestry: {ancestry}");
        Console.WriteLine($"Type: {archetype}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Strength: {strength}");
        Console.WriteLine($"Smarts; {smarts}");
        Console.WriteLine("Abilities:");
        foreach (string x in abilities)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("Gear:");
        foreach(string i in gear)
        {
            Console.WriteLine($"      {i}");
        }
        Console.WriteLine("Minions:");
        foreach (string y in minions)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("Description:");
        Console.WriteLine(visualDescription);
        Console.WriteLine("Lair:");
        Console.WriteLine(lair);


    }
}