using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            // boucle foreach
            /*foreach (var flight in flights)
            {
                if (flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
                }
            }*/
            //// boucle for 
            //for (int i = 0; i < flights.Count; i++)
            //{
            //    if (flights[i].Destination == destination)
            //    {
            //        dates.Add(flights[i].FlightDate);
            //    }
            //}
            //return dates;
            var query1 = from f in flights
                          where f.Destination == destination
                          select f.FlightDate;

            var query2 = flights.Where(f => f.Destination == destination)
                         .Select(f => f.FlightDate);
            return query2.ToList();
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;

                case "EffectiveArrival":
                    foreach (var flight in flights)
                    {
                        if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid filter type");
                    break;
            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query1 = from f in flights
                         where f.Plane == plane
                         select new { f.Destination, f.FlightDate };

            var query2 = flights.Where(f => f.Plane == plane).Select(f => new { f.Destination, f.FlightDate });
            foreach (var f in query1)
            { Console.WriteLine("Destination=" + f.Destination + " Date=" + f.FlightDate); }

        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from flight in flights
                        where flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7)
                        select flight;
            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query1 = (from f in flights
                          where f.Destination == destination
                          select f.EstimationDuration).Average();

            var query2 = flights.Where(f => f.Destination == destination).Select(f => f.EstimationDuration).Average();
            return query1;
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = flights.OrderByDescending(f => f.EstimationDuration);
            return query;
        }

        public List<Traveller> SeniorTravellers(Flight flight)
        {
            var query1 = flight.Passengers.OfType<Traveller>()
                     .OrderBy(p => p.BirthDate)
                     .Take(3)
                     .ToList();

            var query2 = (from f in flight.Passengers.OfType<Traveller>()
                          orderby f.BirthDate
                          select f).Take(3);
            return query1;
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var query1 = flights.GroupBy(f => f.Destination);

            foreach (var item in query1)
            {
                Console.WriteLine("\n Destination : " + item.Key);
                foreach (var flight in item)
                {
                    Console.WriteLine(flight.FlightId +  " Départ: " + flight.Departure + " Date: " + flight.FlightDate);
                }
            }
            return query1;

        }
    }
}
