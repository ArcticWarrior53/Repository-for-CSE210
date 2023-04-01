public class Warrior : BadGuy 
{
    public void WarriorDescription()
    {
        Console.WriteLine("Warriors are the ultimate expression of martial might, using their skill with a blade to conquer their foes and scar the innocent.");
        _health = 2;
        _strength = 3;
        _smarts = 1;
        _names = new List<string>{"Toman Tallscar", "Sathi Amberripper", "Shirra Ashswallow", "Hue Whisperaxe", "Gardaris Whitherhold", "Alexa Zia, The Ice Queen", "Erskarat Fireblood"};
        _ArchetypeAbilities = new List<string>{"Warrior Ability - Cleave\nThe Warrior makes a wide sweeping melee attack, dealing high damage over a small area.", "Warrior Ability - Rage\nLarge bonus to damage, resists incoming damage.",
        "Warrior Ability - Throw Enemy\nPick up an enemy of the same size or smaller, and throw it at another enemy, knocking them down and dealing middling damage.", "Warrior Ability - Feint\nMake the enemy open to attack, giving the warrior and his minions a bonus on the next attack.", 
        "Warrior Ability - Shield Bash\nAttacks the target with the shield, knocking it off gaurd and doing a little damage.", "Warrior Ability - Counterattack\nWhen an enemy attack misses the bad guy, immediately perform an attack on that enemy.",
        "Warrior Ability - Throw Weapon\nThrow a weapon at mid range to deal small damage.", "Warrior Ability - Battle Roar\nIntimidate enemies in a large area.",
        "Warrior Ability - To My Banner!\nGives a morale boost to all minions in a large area.", "Warrior Ability - Combat Acrobatics\nFights in a mesmerizing and acrobatic way. Bonus to dodge enemy attacks, moves faster."};
         _ArchetypeMinions = new List<string>{"Druids", "Bandits", "Rangers", "Dragon", "Knights", "Troll", "Wizard", "Barbarians", "War Wolves", "Orcs"};
    }
    
    public override List<string> gearPrompt() //randomly generates magical items, has the option to input items as well
    {
        Random whatfor = new Random();
        Console.WriteLine("Your Warrior has the following gear: ");
        int coinflip = whatfor.Next(1, 3);
        if (coinflip == 1)
        {
            Console.WriteLine("Magical Sword");
            _gear.Add("Magical Sword");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Magical Axe");
            _gear.Add("Magical Axe");
        }
        Console.WriteLine("Magical Armor");
        _gear.Add("Magical Armor");
        coinflip = whatfor.Next(1, 3);
        if (coinflip == 1)
        {
            Console.WriteLine("Longbow of Fire");
            _strength += 1;
            _gear.Add("Longbow of Fire");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Shield of Spell Deflection");
            _health += 1;
            _gear.Add("Shield of Spell Deflection");
        }
        coinflip = whatfor.Next(1, 4);
        if (coinflip == 1)
        {
            Console.WriteLine("Crossbow of Tracking Missiles");
            _smarts += 1;
            _gear.Add("Crossbow of Tracking Missiles");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Boots of Speed");
            _strength += 1;
            _gear.Add("Headband of Power");
        }
        else if (coinflip == 3)
        {
            Console.WriteLine("Cloak of Protection");
            _health += 1;
            _gear.Add("Cloak of Protection");
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
        Console.WriteLine("Warriors are often heavily armored knights, clad in menacing black armor and wielding nasty looking weapons, but they can also be the archer that sends arrows into the backline,");
        Console.WriteLine("They can be the scantily clad barbarian, relying on their rage and ferocity to protect them in combat.");
        Console.WriteLine("Warriors are usually quite easy to spot in a crowd, being very muscular, wearing armor, and carrying big weapons.");
        Console.WriteLine("Enter the description of your bad guy");
        _visualDescription = Console.ReadLine();
        return _visualDescription;

    }

    public override List<string> minionsPrompt() //randomly generates minions and adds to list
    {
        Console.WriteLine("Your Warrior has the following minions:");
        List<string> availableMin = RandomAbilities(10, 5, _ArchetypeMinions);
        foreach (string minion in availableMin)
        {
            Console.WriteLine(minion);
            _minions.Add(minion);
        }
        Console.WriteLine("Enter any additional minions:");
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