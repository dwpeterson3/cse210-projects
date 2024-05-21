using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetTop());
        fraction1.SetTop(10);
        fraction1.Display();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());  

        
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Your original numerator is {fraction2.GetTop()}.");
        fraction2.Display(); 
        fraction2.SetTop(150);
        Console.WriteLine($"Now your numerator is {fraction2.GetTop()}");
        fraction2.SetBottom(300);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());  
        fraction2.Display();

        Fraction fraction3 = new Fraction(6,7);
        fraction3.Display(); 
        fraction3.SetBottom(3); 
        fraction3.Display(); 
        Console.WriteLine(fraction3.GetDecimalValue()); 
       
        

        
    }
}