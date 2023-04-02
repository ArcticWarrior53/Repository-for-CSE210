using System;

class Program
{
    static void Main(string[] args)
    {
        RecordSheet recordit = new RecordSheet();
        SaveBadguy SaveMe = new SaveBadguy();
        Menu onlyMenu = new Menu();
        int input = onlyMenu.MenuInput();
        if (input == 1)
        {
            Spellcaster spellboy = new Spellcaster();
            spellboy.SpellcasterDescription();
            string ancestry = spellboy.ancestryPrompt();
            string name = spellboy.namePrompt();
            List<string> abilities = spellboy.abilitiesPrompt();
            List<string> gear = spellboy.gearPrompt();
            List<string> minion = spellboy.minionsPrompt(10, 4);
            List<string> goals = spellboy.goalsPrompt();
            string lair = spellboy.lairPrompt();
            string visual = spellboy.descriptionPrompt();
            string health = spellboy.SetStats(spellboy._health);
            string strength = spellboy.SetStats(spellboy._strength);
            string smarts = spellboy.SetStats(spellboy._smarts);
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Spellcaster", health, strength, smarts);
            SaveMe.SaveToFile(name, ancestry, abilities, gear, 
            minion, lair, visual, "Spellcaster", health, strength, smarts);

        }
        if (input == 2)
        {
            Warrior warboy = new Warrior();
            warboy.WarriorDescription();
            string ancestry = warboy.ancestryPrompt();
            string name = warboy.namePrompt();
            List<string> abilities = warboy.abilitiesPrompt();
            List<string> gear = warboy.gearPrompt();
            List<string> minion = warboy.minionsPrompt(10, 5);
            List<string> goals = warboy.goalsPrompt();
            string lair = warboy.lairPrompt();
            string visual = warboy.descriptionPrompt();
            string health = warboy.SetStats(warboy._health);
            string strength = warboy.SetStats(warboy._strength);
            string smarts = warboy.SetStats(warboy._smarts);
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Warrior", health, strength, smarts);
            SaveMe.SaveToFile(name, ancestry, abilities, gear, 
            minion, lair, visual, "Warrior", health, strength, smarts);

        }
        if (input == 3)
        {
            Mastermind mindboy = new Mastermind();
            mindboy.MastermindDescription();
            string ancestry = mindboy.ancestryPrompt();
            string name = mindboy.namePrompt();
            List<string> abilities = mindboy.abilitiesPrompt();
            List<string> gear = mindboy.gearPrompt();
            List<string> minion = mindboy.minionsPrompt(10, 6);
            List<string> goals = mindboy.goalsPrompt();
            string lair = mindboy.lairPrompt();
            string visual = mindboy.descriptionPrompt();
            string health = mindboy.SetStats(mindboy._health);
            string strength = mindboy.SetStats(mindboy._strength);
            string smarts = mindboy.SetStats(mindboy._smarts);
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Mastermind", health, strength, smarts);
            SaveMe.SaveToFile(name, ancestry, abilities, gear, 
            minion, lair, visual, "Mastermind", health, strength, smarts);

        }
        if (input == 4)
        {
            Monster monchboy = new Monster();
            monchboy.MonsterDescription();
            string ancestry = monchboy.ancestryPrompt();
            string name = monchboy.namePrompt();
            List<string> abilities = monchboy.abilitiesPrompt();
            List<string> gear = monchboy.gearPrompt();
            List<string> minion = monchboy.minionsPrompt(10, 2);
            List<string> goals = monchboy.goalsPrompt();
            string lair = monchboy.lairPrompt();
            string visual = monchboy.descriptionPrompt();
            string health = monchboy.SetStats(monchboy._health);
            string strength = monchboy.SetStats(monchboy._strength);
            string smarts = monchboy.SetStats(monchboy._smarts);
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Monster", health, strength, smarts);
            SaveMe.SaveToFile(name, ancestry, abilities, gear, 
            minion, lair, visual, "Monster", health, strength, smarts);

        }
    }
}