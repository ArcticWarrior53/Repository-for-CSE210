public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    
    public string GetHomeWorkList()
    {
        Console.WriteLine("What is the section?");
        _textBookSection = Console.ReadLine();
        Console.WriteLine("What are the problems?");
        _problems = Console.ReadLine();
        string summary = $"Section {_textBookSection} Problems {_problems}";
        return summary;
    }
    

}