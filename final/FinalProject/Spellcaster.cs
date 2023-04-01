public class Spellcaster : BadGuy 
{
    public void SpellcasterDescription()
    {
        Console.WriteLine("Spellcasters are masters of magic, controlling battlefields, creating magic items, and obliterating enemies with words of power.");
        _health = 2;
        _strength = 1;
        _smarts = 3;
        _names = new List<string>{"Mitvesk Rugomu", "Evius Icefield", "Kadarin Felwalker", "Varth Deathscribe", "Jathe Jaoy", "Tothek Nadzilze", "Icarian Wingtear"};
        _ArchetypeAbilities = new List<string>{"Spellcaster Ability - Fireball\nCreate a ball of fire in a large sphere that deals high damage.", "Spellcaster Ability - Control Weather\nChange the weather in a large area around you",
        "Spellcaster Ability - Transform\nTransform into a monster, animal, or other creature.", "Spellcaster Ability - Summon\nSummon animals, undead, or monsters.", 
        "Spellcaster Ability - Raise Undead\nCreate Zombies, Skeletons, or Undead.", "Spellcaster Ability - Shield\nBlock one attack from an enemy",
        "Spellcaster Ability - Counterspell\nInterrupt another caster and dispel their spell.", "Spellcaster Ability - Lightning Bolt\nSummon a lightning bolt, dealing extremly high damage.",
        "Spellcaster Ability - Capture\nCapture the enemy using chains, vines, or ropes.", "Spellcaster Ability - Magic Missile\nFire off three magic missiles, doing middling damage, these missiles can't miss."};
        _ArchetypeMinions = new List<string>{"Apprentice Spellcaster", "Bandits", "Living Statues", "Dragon", "Knights", "Goblins", "Skeletons", "Barbarians", "Werewolves", "Orcs"};
    }

    public override List<string> gearPrompt() //randomly generates magical items, has the option to input items as well
    {
        Random whatfor = new Random();
        Console.WriteLine("Your Spellcaster has the following gear: ");
        int coinflip = whatfor.Next(1, 3);
        if (coinflip == 1)
        {
            Console.WriteLine("Magical Staff");
            _gear.Add("Magical Staff");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Magical Wand");
            _gear.Add("Magical Wand");
        }
        Console.WriteLine("Spellbook");
        _gear.Add("Spellbook");
        int d2 = whatfor.Next(1, 3);
        if (d2 == 1)
        {
            Console.WriteLine("Wizard Robes");
            _gear.Add("Wizard Robes");
        }
        else if (d2 == 2)
        {
            Console.WriteLine("Sorceror's Heavy Armor");
            _health += 1;
            _gear.Add("Sorceror's Armor");
        }
        int d3 = whatfor.Next(1, 4);
        if (d3 == 1)
        {
            Console.WriteLine("Ring of Protection");
            _health += 1;
            _gear.Add("Ring of Protection");
        }
        else if (d3 == 2)
        {
            Console.WriteLine("Headband of Power");
            _smarts += 1;
            _gear.Add("Headband of Power");
        }
        else if (d3 == 3)
        {
            Console.WriteLine("Longsword of Strength");
            _strength += 1;
            _gear.Add("Longsword of Strength");
        }
        string input;
        Console.WriteLine("Enter any additional gear that your bad guy has, and type 'exit' when you are finished:");
        do
        {
            Console.Write("Gear name: ");
            input = Console.ReadLine();
            if (input.ToLower() != "exit")
            {
                _gear.Add(input);
            }
        } while (input.ToLower() != "exit");
        return _gear;
    }

    public override string descriptionPrompt() //– this will give them ideas, rather than a full appearance, they will write the description themselves
    {
        Console.WriteLine("Spellcasters are often depicted as old men in robes, like gandalf, but can also be heavily armored magical warriors, like the Witch-King of Angmar.");
        Console.WriteLine("Spellcasters can also be agile and scrappy, wearing rags and beign acrobatic in combat");
        Console.WriteLine("Finally, Spellcasters often have an outward sign of their magic - glowing eyes, magical tattoos, obvious magical items");
        Console.WriteLine("Enter the description of your Spellcaster");
        _visualDescription = Console.ReadLine();
        return _visualDescription;

    }

     public override List<string> minionsPrompt() //randomly generates minions and adds to list
    {
        Console.WriteLine("Your Spellcaster has the following minions:");
        List<string> availableMin = RandomAbilities(10, 4, _ArchetypeMinions);
        foreach (string minion in availableMin)
        {
            Console.WriteLine(minion);
            _minions.Add(minion);
        }
        Console.WriteLine("Enter any additional minions, and enter 'exit' when you are ready to continue.");
        string additionalminion;
        do
        {
            Console.Write("Minion: ");
            additionalminion = Console.ReadLine();
            if (additionalminion.ToLower() != "exit")
            {
                _minions.Add(additionalminion);
            }
        } while(additionalminion.ToLower() != "exit");
        
        return _minions;

    }
}