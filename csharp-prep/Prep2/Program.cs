using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);
        
        string letter = "";

        if (x >= 90)
        {
           letter = "A";
        }
        else if (x < 90 && x >= 80)
        {
            letter = "B";
            
        }        
        else if (x < 80 && x >= 70)
        {
            letter = "C";
            
        }
        else if (x < 70 && x >= 60)
        {
            letter = "D";
            
        }
        else
        {
            letter = "F";
        
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations!! You Passed! ");

        } 
        else 
        {
            Console.WriteLine("Yikes! Study harder next time! ");
        }


    }
}