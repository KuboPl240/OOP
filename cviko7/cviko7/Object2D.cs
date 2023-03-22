using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko7
{
    internal abstract class Object2D : I2D, IComparable
    {
        public abstract double Surface();
        public int CompareTo(object obj)
        {

            if (obj == null)
            {
                return 1;
            }
            Object2D otherSurface = obj as Object2D;
            if (otherSurface != null)
            {
                return this.Surface().CompareTo(otherSurface.Surface());
            }

            else
            {
                throw new ArgumentException("not possible to compare");
            }
        }
    }
    internal class Rectangle : Object2D
    {
        private double a = 0, b = 0;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Surface()
        {
            return a * b;
        }
        public override string ToString()
        {
            return new String($"Rectangle size: {a}*{b}");
        }

    }
    internal class Square : Object2D
    {
        private double a = 0;
        public Square(double a)
        {
            this.a = a;
        }
        public override double Surface()
        {
            return a * a;
        }
        public override string ToString()
        {
            return new String($"Square size: {a}*{a}");
        }

    }
    internal class Circle : Object2D
    {
        private double radius = 0;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Surface()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return new String($"Circle size: {radius}");
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

        public override double Surface()
        {
            return (height * Base) / 2;
        }
        public override string ToString()
        {
            return new String($"Triangle size: base:{Base}, height:{height}");
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

        public override double Surface()
        {
            return a * b * Math.PI;
        }
        public override string ToString()
        {
            return new String($"Ellipse: base:{a}*{b}");
        }

    }
}

