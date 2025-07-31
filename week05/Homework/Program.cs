using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment(assignment.GetStudentName(), assignment.GetTopic(), "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writing = new WritingAssignment(assignment.GetStudentName(), assignment.GetTopic(), "Formulas and Examples");
        Console.WriteLine(writing.GetWritingInformation());
    }
}
