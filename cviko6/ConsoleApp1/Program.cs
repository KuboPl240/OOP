// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

GrObject[] objects = new GrObject[8];
double totalVolume = 0, totalArea = 0, totalSurface = 0;

objects[0] = new Rectangle(10,10);
objects[1] = new Circle(10);
objects[2] = new Triangle(10, 10);
objects[3] = new Ellipse(10, 10);
objects[4] = new Cuboid(10, 10, 10);
objects[5] = new Cylinder(10, 10);
objects[6] = new Sphere(10);
objects[7] = new Pyramid(10, 10);


foreach (GrObject o in objects)
{
    o.draw();
    if(o is Object2D object2D)
    {
        totalArea += object2D.Area();
    }
    if (o is Object3D object3D)
    {
        totalSurface += object3D.Surface();
        totalVolume += object3D.Volume();
    }
}
Console.WriteLine($"Total volume is {totalVolume}\nTotal surface is {totalSurface}\nTotal area is {totalArea}");