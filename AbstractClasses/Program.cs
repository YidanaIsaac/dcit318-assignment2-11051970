﻿using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius) => Radius = radius;
    public override double GetArea() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double GetArea() => Width * Height;
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }
}
