public class Ancestries
{
    List<string> _coreAncestries = new List<string>{"Human", "Elf", "Dwarf", "Halfling", "Giant", "Dragon", 
    "Lich", "Tiefling", "Demon", "Dracolich", "Vampire","Devil", "Construct", "Djinn", 
    "Beholder", "Wraith", "Eldritch Horror", "Werecreature", "Elemental", "Goblin", "Orc", 
    "Troll", "Half-Elf"};
    List<List<string>> _ancestryAbilities = new List<List<string>>{
        new List<string> {"Human Ability - Adaptability", "Human Ability - Toughness"},
        new List<string> {"Elf Abilty - NightSight", "Elf Ability - Magic"}
    };

    public void randomAbilitiesSelection(int number, int ancestry)
    {
        Random random1 = new Random();
        int random = random1.randomGenerator();
        string abilities = _ancestryAbilities[ancestry][random];
    }

}