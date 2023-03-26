using System;

class Program
{
    static void Main(string[] args)
    {
        RecordSheet recordit = new RecordSheet();
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
            List<string> minion = spellboy.minionsPrompt();
            List<string> goals = spellboy.goalsPrompt();
            string lair = spellboy.lairPrompt();
            string visual = spellboy.descriptionPrompt();
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Spellcaster", "Low", "Low", "Extremely High");

        }
        if (input == 2)
        {
            Warrior warboy = new Warrior();
            warboy.WarriorDescription();
            string ancestry = warboy.ancestryPrompt();
            string name = warboy.namePrompt();
            List<string> abilities = warboy.abilitiesPrompt();
            List<string> gear = warboy.gearPrompt();
            List<string> minion = warboy.minionsPrompt();
            List<string> goals = warboy.goalsPrompt();
            string lair = warboy.lairPrompt();
            string visual = warboy.descriptionPrompt();
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Warrior", "Medium", "High", "Low");

        }
        if (input == 3)
        {
            Mastermind mindboy = new Mastermind();
            mindboy.MastermindDescription();
            string ancestry = mindboy.ancestryPrompt();
            string name = mindboy.namePrompt();
            List<string> abilities = mindboy.abilitiesPrompt();
            List<string> gear = mindboy.gearPrompt();
            List<string> minion = mindboy.minionsPrompt();
            List<string> goals = mindboy.goalsPrompt();
            string lair = mindboy.lairPrompt();
            string visual = mindboy.descriptionPrompt();
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Mastermind", "Low", "Medium", "Extremely High");

        }
        if (input == 4)
        {
            Monster monchboy = new Monster();
            monchboy.MonsterDescription();
            string ancestry = monchboy.ancestryPrompt();
            string name = monchboy.namePrompt();
            List<string> abilities = monchboy.abilitiesPrompt();
            List<string> gear = monchboy.gearPrompt();
            List<string> minion = monchboy.minionsPrompt();
            List<string> goals = monchboy.goalsPrompt();
            string lair = monchboy.lairPrompt();
            string visual = monchboy.descriptionPrompt();
            recordit.CreateRecordSheet(name, ancestry, abilities, gear, 
            minion, lair, visual, "Monster", "Highm", "High", "Extremely Low");

        }
    }
}