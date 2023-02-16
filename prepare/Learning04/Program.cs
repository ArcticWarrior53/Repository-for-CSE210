using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment wizardThesis = new WritingAssignment();
        string nameNTopic = wizardThesis.GetSummary();
        string wizardTitle = wizardThesis.GetWritingInformation();
        Console.WriteLine(nameNTopic);
        Console.WriteLine(wizardTitle);
    }
}