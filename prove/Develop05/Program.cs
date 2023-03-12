using System;

class Program
{
    static void Main(string[] args)
    {
        Menu interact = new Menu();
        Player me = new Player();
        me.login();
        string input = "";
        while (input != "6")
        {
            me.ExperienceBar();
            input = interact.MenuInput();
            if (input == "1")
            {
                input = interact.CreateGoal();
                if (input=="1")
                {
                    string title = me.CreateTitle();
                    string description = me.CreateDescription();
                    int points = me.CreatePoints();
                    Simple simp = new Simple(title, description, points);
                    me._goals.Add(simp); 
                }
                else if (input=="2")
                {
                    string title = me.CreateTitle();
                    string description = me.CreateDescription();
                    int points = me.CreatePoints();
                    Eternal etern = new Eternal(title, description, points);
                    me._goals.Add(etern);
                }
                else if (input=="3")
                {
                    string title = me.CreateTitle();
                    string description = me.CreateDescription();
                    int points = me.CreatePoints();
                    int timesTo = me.CreateTotal();
                    int bonus = me.CreateBonus();
                    Checklist check = new Checklist(title, description, points, timesTo, bonus);
                    me._goals.Add(check);
                }
            }
            else if (input == "2")
            {
                me.listGoals();
            }
            else if (input == "3")
            {
                me.SaveGoals();
            }
            else if (input == "4")
            {
                me.LoadGoals();
            }
            else if (input == "5")
            {
                me.RecordEvent();
            }
            else if (input == "6")
            {
                me.SaveGoals();
                interact.Quit();
            }
        }
        

    }
}