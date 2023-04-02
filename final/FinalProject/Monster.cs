public class Monster : BadGuy 
{
    public void MonsterDescription()
    {
        Console.WriteLine("Put description here");
        _health = 4;
        _strength = 4;
        _smarts = 0;
        _names = new List<string>{"Lagwin the Typhoon", "Fireheart the Inferno", "Horcrud the Voidbelly", "Baku, Champion of the Yellow", "Nyrrag, Deathbringer", "Liphe, Destroyer of Men", "Syrsen, the Mindbreaker"};
        _ArchetypeAbilities = new List<string>{"Monster Ability - Breath Attack\nThe Monster breaths out elemental energy in a wide cone, dealing high damage", "Monster Ability - Feral Claws\nThe Monster grows claws, which deal high damage.",
        "Monster Ability - Destroy Building\nThe Monster destroys a nerby building with a single blow.", "Monster Ability - Throw Boulder\nThe monsster picks up a large object and hurls it, dealing high damage in a small area.", 
        "Monster Ability - Rend Item\nDestroys non-magical item target is wielding.", "Monster Ability - Resistance\nThe Monster is resistant to a damage type.",
        "Monster Ability - Tail Attack\nThe Monster has a tail and uses it to deal middling damage to two targets behind it or two the side of it as a free action.", "Monster Ability - Bestial Roar\nCalls monster allies, making two appear in one round.",
        "Monster Ability - Swallow Foe\nSwallows an enemy whole, dealing middling damage each round unless they are freed.", "Monster Ability - Rage of the Titan\nThe Monster takes two additional actions for free this round, it may do this once per combat."};
        _ArchetypeMinions = new List<string>{"Demon Worshiper", "Giant Birds", "Demon", "Dragons", "Zombies", "Kobolds", "Fanatic", "Barbarians", "Werewolves", "Orcs"};
    }
    
     public override List<string> gearPrompt() //randomly generates magical items, has the option to input items as well
    {
        Random whatfor = new Random();
        Console.WriteLine("Your Monster does not have any gear.");
        _gear.Add("Your monster does not have any gear");
        return _gear;
    }

    public override string descriptionPrompt() //– this will give them ideas, rather than a full appearance, they will write the description themselves
    {
        Console.WriteLine("Monsters are hulking brutes, terrifying lizards, or the agile but brutal vampires. The often look brutish and ugly, covered in mud and grime");
        Console.WriteLine("There are quite a variety of monsters out there, but they almost always have sharp fangs, claws, or tails");
        Console.WriteLine("Enter the description of your bad guy");
        _visualDescription = Console.ReadLine();
        return _visualDescription;

    }
}