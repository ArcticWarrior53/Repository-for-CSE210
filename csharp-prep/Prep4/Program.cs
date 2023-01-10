using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numlist = new List<int>();
        int number;
        int length = 0;
        do
        {
            Console.Write("Enter number: ");
            string StrNumber = Console.ReadLine();
            number = int.Parse(StrNumber);
            if (number != 0)
            {
                numlist.Add(number);
                length++;
            }
            
        } while(number != 0);
        int sum = 0;
        int largest = 0;
        foreach (int num in numlist)
        {
            if (num > largest)
            {
                largest = num;
            }
            sum = num + sum; 
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum/length;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}