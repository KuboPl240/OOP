// See https://aka.ms/new-console-template for more information
using cviko7;
using System;
using System.Collections;

int[] arrayInt = { 1, 3, 4, 5, 6, 7, 9 };

string[] arrayStr = {
                "string1",
                "string2",
                "string3"
            };

Circle[] cirles = {
                new Circle(2),
                new Circle(5)
            };

Square[] squares = {
                new Square(2),
                new Square(18),
                new Square(5)
            };

Ellipse[] elipses = {
                new Ellipse(2, 3),
                new Ellipse(10, 8),
                new Ellipse (1, 5)
            };

Rectangle[] rectangles = {
                new Rectangle(1, 4),
                new Rectangle(8, 2),
                new Rectangle(2, 50)
            };

Triangle[] triangles = {
                new Triangle(6, 4),
                new Triangle(16, 6),
                new Triangle(10, 8)
            };

Object2D[] objekt2Ds = {
                new Circle(2),
                new Rectangle(10,8),
                new Ellipse(4, 5),
                new Rectangle(8, 2),
                new Triangle(14, 6)
};

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(arrayInt));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(arrayInt));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(arrayStr));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(arrayStr));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(cirles));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(cirles));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(squares));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(squares));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(elipses));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(elipses));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(rectangles));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(rectangles));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(triangles));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(triangles));
Console.WriteLine();

Console.WriteLine("BIGGEST  : {0}", Extreme.Biggest(objekt2Ds));
Console.WriteLine("SMALLEST : {0}", Extreme.Smallest(objekt2Ds));
Console.WriteLine();

IEnumerable<int> scoreQuery = from value in arrayInt where (value > 4 && value < 8) select value;
foreach (int i in scoreQuery)
{
    Console.Write(i + " ");
}