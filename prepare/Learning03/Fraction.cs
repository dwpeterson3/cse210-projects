using System.ComponentModel.DataAnnotations;

public class Fraction
{
   private int _top;
   private int _bottom; 

   public Fraction()
   {
    _top = 1;
    _bottom = 1; 
   }

   public void Display()
   {
    Console.WriteLine($"Your fraction is {_top} / {_bottom}"); 
   }


   public Fraction(int wholeNumber)
   {
    _top = wholeNumber;
    _bottom = 1;
   }
   public Fraction(int top, int bottom)
   {
    _top = top;
    _bottom = bottom; 

   }

   public int GetTop()
   {
    return _top; 
   }
   public void SetTop(int numerator)
   {
      _top = numerator;
   }

   public int GetBottom()
   {
    return _bottom; 
   }
   public void SetBottom(int denominator)
   {
      _bottom = denominator; 
   }
   public string GetFractionString()
   {
      string text = $"{_top}/{_bottom}"; 
      return text;
   }
   public double GetDecimalValue()
   {
      double value =  (double)_top / (double)_bottom; 
      return value;   
   }

}