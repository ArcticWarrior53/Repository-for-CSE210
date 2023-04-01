public class Mastermind : BadGuy 
{

    public void MastermindDescription()
    {
        Console.WriteLine("Masterminds are the ultimate planners, waiting decades, or sometimes centuries, for their plans to com into effect. These are the hunters, the buisnessmen, and the femme fatales. Extremly intelligent, cross this BBEG and you will find yourself outplanned.");
        _health = 0;
        _strength = 2;
        _smarts = 5;
        _names = new List<string>{"Allard Westin", "Rava Lia", "Hadur Hawkmeister", "Jilleera Horntrapper", "The Iy", "Steleeth Sacredmark", "Hilaya Friend"};
        _ArchetypeAbilities = new List<string>{"Mastermind Ability - Friends in High Places\nThe Mastermind can pull strings to get aid.", "Mastermind Ability - Irrefutable Logic\nThe villain persuades the target to do what they ask",
        "Mastermind Ability - Bodygaurd's Sacrifice\nA Nearby minion throws itself in front of an attack, taking the damage for them.", "Mastermind Ability - Superior Planning\nWhen two or more minions work together on a skill, they get a bonus per minion.", 
        "Mastermind Ability - Set Up Ambush\nCreate an undetectable ambush.", "Mastermind Ability - Create Counterfeit\nCreate a counterfeit that is identical to the original.",
        "Mastermind Ability - Demagaugery\nWhip up a crowd into a mob.", "Mastermind Ability - Ventriliquism\nMake their voice sound like its from some other area.",
        "Mastermind Ability - Inspire\nGives a bonus to the minions in a large radius.", "Mastermind Ability - Master of Deception\nIs extremely deceptive and can detect almost any lie."};
         _ArchetypeMinions = new List<string>{"Wizard", "Bandits", "Demon", "Dragon", "Knights", "Goblins", "Fanatic", "Barbarians", "Werewolves", "Orcs"};
    }

    public override List<string> gearPrompt() //randomly generates magical items, has the option to input items as well
    {
        Random whatfor = new Random();
        Console.WriteLine("Your Mastermind has the following gear: ");
        int coinflip = whatfor.Next(1, 3);
        if (coinflip == 1)
        {
            Console.WriteLine("Book of Ancient Secrets");
            _gear.Add("Book of Ancient Secrets");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Crystal Ball");
            _gear.Add("Crystal Ball");
        }
        Console.WriteLine("Blackmail on important people");
        _gear.Add("Blackmail on important people");
        coinflip = whatfor.Next(1, 3);
        if (coinflip == 1)
        {
            Console.WriteLine("Rapier of Phasing");
            _strength += 1;
            _gear.Add("Rapier of Phasing");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Ring of Futuresight");
            _smarts += 1;
            _gear.Add("Ring of Futuresight");
        }
        coinflip = whatfor.Next(1, 4);
        if (coinflip == 1)
        {
            Console.WriteLine("Pendant of Lie Detection");
            _smarts += 1;
            _gear.Add("Pendant of Lie Detection");
        }
        else if (coinflip == 2)
        {
            Console.WriteLine("Gauntlets of Telekinesis");
            _strength += 1;
            _gear.Add("Gauntlets of Telekinesis");
        }
        else if (coinflip == 3)
        {
            Console.WriteLine("Ring of Teleportation");
            _health += 1;
            _gear.Add("Ring of Teleportation");
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
        Console.WriteLine("Masterminds are often men in fancy buisness suits or women in sleek dresses, but can also be vagabonds in rags or the simple farmer.");
        Console.WriteLine("Masterminds tend not to stick out unless they want to - if you can easily spot one, it's because they want you to.");
        Console.WriteLine("Finally, Masterminds often wear disguises, so maybe also create a common disguise for them.");
        Console.WriteLine("Enter the description of your Mastermind");
        _visualDescription = Console.ReadLine();
        return _visualDescription;

    }

    public override List<string> minionsPrompt() //randomly generates minions and adds to list
    {
        Console.WriteLine("Your Mastermind has the following minions:");
        List<string> availableMin = RandomAbilities(10, 6, _ArchetypeMinions);
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