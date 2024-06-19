using System;
using System.Drawing;
using System.Formats.Asn1;

public class Square : Shape
{
    private double _side;
    public Square(double side, string color) : base(color)
    {
        _side = side; 
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area; 
    }
}