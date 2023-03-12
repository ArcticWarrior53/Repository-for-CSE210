using System.Collections.Generic;

public class Goal
{
    protected string _goalType;
    protected string _title;
    protected string _description;
    protected int _pointValue;

   
    public virtual void DisplayGoal(int x=0)
    {
        Console.WriteLine("You shouldn't see this line");
    }
    public virtual int Record()
    {
        Console.WriteLine("You shouldn't see this line");
        int zero = 0;
        return zero;
    }
    

        public virtual string GetInfo()
        {
            return "Eternal//"+$"{_title}//"+$"{_description}//"+$"{_pointValue}//";
        }
}