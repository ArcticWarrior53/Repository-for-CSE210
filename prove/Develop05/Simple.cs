using System.Collections.Generic;

public class Simple : Goal
{
   protected bool _isCompleted;
   public Simple(string title, string description, int points, bool iscompleted=false)
        {
            _goalType = "simple";
            _title = title;
            _description = description;
            _pointValue = points;
            _isCompleted = iscompleted;
        }
    public override int Record()
    {
        Experience goalXP = new Experience();
            _isCompleted = true;
            goalXP.addExperience(_pointValue);
            return goalXP._XPbar;
    }

    public override void DisplayGoal(int x)
    {
        if (_isCompleted == true)
            {
                Console.WriteLine($"[X] {_title} ({_description})");
            }
            else
            {
                Console.WriteLine($"[ ] {_title} ({_description})");
            }
    }
    public override string GetInfo()
        {
            return "Simple//"+$"{_title}//"+$"{_description}//"+$"{_pointValue}//"+$"{_isCompleted}//";
        }

}