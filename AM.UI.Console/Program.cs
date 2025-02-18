// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore;
using AM.ApplicationCore.Services;

/*Plane plane = new Plane();
plane.PlaneType = PlaneType.Airbus;
plane.Capacity = 200;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane);

Plane plane2 = new Plane
{
    PlaneType = PlaneType.Airbus,
    Capacity = 200,
    ManufactureDate = DateTime.Now
};

Console.WriteLine(plane);*/

/*Plane plane3 = new Plane(300, DateTime.Now, PlaneType.Boing);
Console.WriteLine(plane3);*/

/*Passenger passenger = new Passenger
{
    EmailAdress = "nour.louhaichi@esprit.tn",
    FirstName = "Nour",
    LastName = "Louhaichi"
};
Console.WriteLine(passenger.CheckProfile("Nour","Louhaichi"));
Console.WriteLine(passenger.CheckProfile("Nour", "Louhaichi","nour"));

Staff  staff  = new Staff
{
    EmailAdress = "nour.louhaichi@esprit.tn",
    FirstName = "Nour",
    LastName = "Louhaichi"
};

Traveller traveller  = new Traveller
{
    EmailAdress = "nour.louhaichi@esprit.tn",
    FirstName = "Nour",
    LastName = "Louhaichi"
};

passenger.PassengerType();
staff.PassengerType();
traveller.PassengerType();*/


ServiceFlight serviceFlight = new ServiceFlight();
serviceFlight.flights = TestData.listFlights;
/*foreach (var item in serviceFlight.GetFlightDates("Madrid"))
{
    Console.WriteLine(item.ToString());
}*/

serviceFlight.GetFlights("Destination", "Madrid");



