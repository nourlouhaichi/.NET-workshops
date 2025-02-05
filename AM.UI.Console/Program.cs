// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore;

Console.WriteLine("Hello, World!");
/*Plane plane = new Plane();
plane.PLaneType = PlaneType.Airbus;
plane.Capacity = 200;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane);

Plane plane2 = new Plane
{
    PLaneType = PlaneType.Airbus,
    Capacity = 200,
    ManufactureDate = DateTime.Now
};

Console.WriteLine(plane);*/

Plane plane3 = new Plane(300, DateTime.Now, PlaneType.Boing);
Console.WriteLine(plane3);


