public class Ancestries
{
    List<string> _coreAncestries = new List<string>{"Human", "Elf", "Dwarf", "Halfling", "Giant", "Dragon", 
    "Lich", "Demon", "Vampire", "Construct", "Werewolf",  "Orc"};
    List<List<string>> _ancestryAbilities = new List<List<string>>{
        //0 Humans
        new List<string> {"Human Ability - Adaptability\nCan adapt to any climate or situation", "Human Ability - Toughness\nIs very hard to kill"},
        //1 Elves
        new List<string> {"Elf Abilty - NightSight\nCan see clearly even in starlight", "Elf Ability - Magic\nCan cast simple magic", "Elf Ability - Agility\nIs exceptionally agile"},
        //2 Dwarves
        new List<string> {"Dwarf Abilty - Cavevision\nCan see even in dark caves", "Dwarf Ability - Craftsman\nCan craft magic items"},
        //3 Halflings
        new List<string> {"Halfling Abilty - Lucky\nIs lucky, and can reroll dice rolls", "Halfling Ability - Hairy Feet\nDoesn't need footwear", "Halfling Ability - Quick Hands\nGets a bonus when doing thigns that require deft handwork"},
        //4 Giants
        new List<string> {"Giant Abilty - Large\nIs very big", "Giant Ability - Mighty Weapons\nWeapons and gear are giant sized", "Giant Ability - Stomp\nCan stomp on enemies, killing them or dealing large amounts of damage"},
        //5 Dragons
        new List<string> {"Dragon Abilty - Fire Breath\nDeals lots of damage in a cone of fire", "Dragon Ability - Flight\nCan fly very fast", "Dragon Ability - Fire Immunity\nIs immune to fire", "Dragon Ability - Claws\nThe Dragon has razor sharp claws"},
        //6 Liches
        new List<string> {"Lich Abilty - Drain Life\nCan touch a target to drain a middling amount of health.", "Lich Ability - Reform\nAfter dying, if his phylactery is intact, he reforms by his phylactery after 2-3 days.", "Lich Ability - Dread Aura\nAll enemies within a large radius must make a check or be scared."},
        //7 Demons
        new List<string> {"Demon Abilty - Fire Claws\nHas flaming claws.", "Demon Ability - Reform\nAfter dying, unless killed by holy affects, the demon reforms in hell after 2-3 days.", "Demon Ability - Summon Lesser Demons\nSummons 1d4 lesser demons."},
        //8 Vampires
        new List<string> {"Vampire Abilty - Drain Blood\nCan bite a target in the neck to drain a large amount of life.", "Vampire Ability - Bat Form\nCan transform into a bat.", "Vampire Ability - Undead\nCan only be killed by a stake into the heart, holy damage, the sun, or if its coffin is destroyed.", "Vampire Ability - Vampire Spawn\n Creatures killed by the vampire's drain blood attack who are buried rise that night as a vampire spawn"},
        //9 Constructs
        new List<string> {"Construct Abilty - Robot\nIs immune to disease, poison, suffocation, and transformation effects.", "Construct Ability - Heavily Armored\nThe Construct is hard to damage, or has a lot of health", "Construct Ability - Eternal Vigil\nDoes not need to sleep."},
        //10 Werewolves
        new List<string> {"Werewolf Abilty - Transform\nCan transform into a wolf form, or into a wolf-human hybrid form. Must transform on nights of a full moon", "Werewolf Ability - Lycanthropic Infection\nIf it bites a humanoid, that humanoid becomes a werewolf at the next full moon.", "Werewolf Ability - Steel Pelt\nThe Werewolf halves all damage, unless the weapon is coated in silver."},
        //11 Orcs
        new List<string> {"Orc Ability - Reckless attack\nCan deal high extra damage on an attack by making itself vulnerable.", "Orc Ability - Fast\nCan move faster than most creatures.", "Orc Ability - Toug\n Can take more damage than most creatures."},
    };

    public int ancestryOptions()
    {
        Random randAncestry = new Random();
        int ancestryOne = randAncestry.Next(0, 11);
        int ancestryTwo;
        int ancestryThree;
        if (ancestryOne != 0)
        {
            ancestryTwo = ancestryOne - 1;
            ancestryThree = ancestryOne +1;
        }
        else if (ancestryOne == 11)
        {
            ancestryTwo = ancestryOne - 1;
            ancestryThree = ancestryOne -2;
        }
        else
        {
            ancestryTwo = ancestryOne +1;
            ancestryThree = ancestryOne +2;
        }
        Console.WriteLine("The options for your ancestry are:");
        Console.WriteLine($"      1. {_coreAncestries[ancestryOne]}");
        Console.WriteLine($"      2. {_coreAncestries[ancestryTwo]}");
        Console.WriteLine($"      3. {_coreAncestries[ancestryThree]}"); 
        Console.WriteLine("Choose One option:");
        int choice = Int32.Parse(Console.ReadLine());
        if (choice == 1)
        {
            return ancestryOne;
        }
        else if (choice == 2)
        {
            return ancestryTwo;
        }
        else if (choice == 3)
        {
            return ancestryThree;
        }
        else
        {
            Console.Write("Selection out of range - Automatically selecting option 1");
            return ancestryOne;
        }
    }
    public List<string> addAbilities(int ancestry)
    {
        List<string> abilities = _ancestryAbilities[ancestry];
        return abilities;
    }
    public string setAncestry(int ancestry)
    {
        string ancestryName = _coreAncestries[ancestry];
        return ancestryName;
    }

}