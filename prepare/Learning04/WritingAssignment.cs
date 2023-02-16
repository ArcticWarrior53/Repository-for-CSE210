public class WritingAssignment : Assignment
{
    private string _title;

    
    public string GetWritingInformation()
    {
        Console.WriteLine("What is the student's name?");
        _studentName = Console.ReadLine();
        Console.WriteLine("What is the title of the paper?");
        _title = Console.ReadLine();
        string summary = $"{_title} by {_studentName}";
        return summary;
    }
    

}