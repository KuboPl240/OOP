using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Object2D : GrObject
    {
        public abstract double Area();
    }

    internal class Rectangle : Object2D
    {
        private double a = 0, b=0;
        public Rectangle(double a, double b){
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a * b; 
        }
        public override void draw()
        {
            Console.WriteLine(new String($"Rectangle size: {a}*{b}"));
        }

    }
    internal class Circle : Object2D
    {
        private double radius = 0;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI*radius*radius;
        }
        public override void draw()
        {
            Console.WriteLine(new String($"Circle size: {radius}"));
        }

    }
    internal class Triangle : Object2D
    {
        private double height = 0, Base = 0;
        public Triangle(double height, double Base)
        {
            this.height = height;
            this.Base = Base;
        }

        public override double Area()
        {
            return (height*Base)/2;
        }
        public override void draw()
        {
            Console.WriteLine(new String($"Triangle size: base:{Base}, height:{height}"));
        }

    }

    internal class Ellipse : Object2D
    {
        private double a = 0, b = 0;
        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area()
        {
            return a*b*Math.PI;
        }
        public override void draw()
        {
            Console.WriteLine(new String($"Ellipse: base:{a}*{b}"));
        }

    }
}

