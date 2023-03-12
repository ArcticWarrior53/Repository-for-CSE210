public class Eternal : Goal
{
   
   public Eternal(string title, string description, int points)
    {
        _goalType = "Eternal";
        _title = title;
        _description = description;
        _pointValue = points;
            
    }
    public override int Record()
    {
        Experience goalXP = new Experience();
        goalXP.addExperience(_pointValue);
        return goalXP._XPbar;
    }

    public override void DisplayGoal(int x = 0)
    {
            Console.WriteLine($"[ ] {_title} ({_description})");
    }
    
}