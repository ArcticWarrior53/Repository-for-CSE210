
public class Checklist : Goal
{
   private int _timesCompleted;
   private int _timesToComplete;
   private int _bonus;
   
   public Checklist(string title, string description, int points, int timestocomplete, int bonus, int timescomp=0)
    {
        _goalType = "checklist";
        _title = title;
        _description = description;
        _pointValue = points;
        _timesToComplete = timestocomplete;
        _bonus = bonus;
        _timesCompleted = timescomp;
            
    }
    public override int Record()
    {
        Experience goalXP = new Experience();
        _timesCompleted++;
        if (_timesCompleted == _timesToComplete)
        {
            goalXP.addExperience(_pointValue + _bonus);
            return goalXP._XPbar;;
        }
        else
        {goalXP.addExperience(_pointValue);
        return goalXP._XPbar;}
    }

    public override void DisplayGoal(int x = 0)
    {
        if (_timesCompleted < _timesToComplete)
        {
            Console.WriteLine($"[ ] {_title} ({_description}) -- currently completed {_timesCompleted}/{_timesToComplete}");
        }
        else if (_timesCompleted >= _timesToComplete)
        {
            Console.WriteLine($"[X] {_title} ({_description}) -- currently completed {_timesCompleted}/{_timesToComplete}");
        }
    }

    public override string GetInfo()
        {
            return "Checklist//"+$"{_title}//"+$"{_description}//"+$"{_pointValue}//"+$"{_bonus}//"+$"{_timesToComplete}//"+$"{_timesCompleted}//";
        }

}