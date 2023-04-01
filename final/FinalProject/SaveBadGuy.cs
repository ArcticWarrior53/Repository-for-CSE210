public class SaveBadguy
{
    public SaveBadguy()
    {
        
    }
    public void SaveToFile(string name, string ancestry, List<String> abilities, List<String> gear, 
    List<string> minions, string lair, string visualDescription, string archetype, string health, string strength, string smarts)
        {
            RecordSheet saveBadGuy = new RecordSheet();
            //Saves goals and player data into a file
            using (StreamWriter file = new StreamWriter($"{name}-{archetype}.txt"))
            {
                
                file.WriteLine($"{name}");
                file.WriteLine($"Ancestry: {ancestry}");
                file.WriteLine($"Type: {archetype}");
                file.WriteLine($"Health: {health}");
                file.WriteLine($"Strength: {strength}");
                file.WriteLine($"Smarts; {smarts}");
                file.WriteLine("Abilities:");
                foreach (string x in abilities)
                {
                    file.WriteLine(x);
                }
                file.WriteLine("Gear:");
                foreach(string i in gear)
                {
                    file.WriteLine($"      {i}");
                }
                file.WriteLine("Minions:");
                foreach (string y in minions)
                {
                    file.WriteLine(y);
                }
                file.WriteLine("Description:");
                file.WriteLine(visualDescription);
                file.WriteLine("Lair:");
                file.WriteLine(lair);
            }
            
        }
}
        