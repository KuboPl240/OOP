using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Object3D : GrObject
    {
        public abstract double Surface();
        public abstract double Volume();
    }

    internal class Cuboid:Object3D
    {
        private double a = 0, b=0,c=0;

        public Cuboid(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Surface()
        {
            return 2 * (a * b + a * c + b * c);    
        }

        public override double Volume()
        {
            return a*b*c;
        }

        public override void draw()
        {
            Console.WriteLine(new String($"Cuboid size: {a}*{b}*{c}"));
        }

    }

    internal class Cylinder : Object3D
    {
        private double radius = 0, height = 0;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double Surface()
        {
            return 2*radius*Math.PI*(radius + height);
        }

        public override double Volume()
        {
            return  height*radius*radius * Math.PI;
        }
        public override void draw()
        {
            Console.WriteLine(new String($"Cylinder size: radius: {radius}, height: {height}"));
        }
    }

    internal class Sphere: Object3D
    {
        private double radius = 0;

        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public override double Surface()
        {
            return 4 * radius * radius * Math.PI;
        }
        public override double Volume()
        {
            return (4/3) *radius * radius * radius * Math.PI;
        }

        public override void draw()
        {
            Console.WriteLine(new String($"Sphere size: radius: {radius}"));
        }

    }

    internal class Pyramid : Object3D
    {
        private double a = 0, height = 0;

        public Pyramid(double a, double height)
        {
            this.a = a;
            this.height = height;
        }

        public override double Surface()
        {
            return a*(a+Math.Sqrt(a*height*height + a*a));
        }

        public override double Volume()
        {
            return (1 / 3)*a*a *height;
        }

        public override void draw()
        {
            Console.WriteLine(new String($"Pyramid size: {a}*{height}"));
        }
    }


}
