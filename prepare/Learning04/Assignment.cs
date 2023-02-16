public class Assignment
{
    //The private variables
    protected string _studentName;
    protected string _topic;

    public string GetSummary()
    {
        Console.WriteLine("What is your name?");
        _studentName = Console.ReadLine();
        Console.WriteLine("What is the topic of the assignment?");
        _topic = Console.ReadLine();
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }

    
}