using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
      Assignment assignment = new Assignment("Derek", "Programming");
      MathAssignment mathAssignment = new MathAssignment("Derek Peterson", "Programming", "7.3", "8-19");
      WritingAssignment writingAssignment = new WritingAssignment("Derek Peterson", "Programing", "Code This Game!!!");

    
      Console.WriteLine(writingAssignment.GetSummary());
      Console.WriteLine(writingAssignment.GetWritingInformation()); 

    }
}