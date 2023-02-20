using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Stephen", "Math"); 
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();
        MathAssignment assignment2 = new MathAssignment("Stephen", "Math", "7", "11-17"); 
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment assignment3 = new WritingAssignment("Stephen", "Writing", "Title of some Book");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}