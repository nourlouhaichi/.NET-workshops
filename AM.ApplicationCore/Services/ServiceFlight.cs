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
            List<DateTime> dates = new List<DateTime>();
            // boucle foreach
            foreach (var flight in flights)
            {
                if (flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
                }
            }
            //// boucle for 
            //for (int i = 0; i < flights.Count; i++)
            //{
            //    if (flights[i].Destination == destination)
            //    {
            //        dates.Add(flights[i].FlightDate);
            //    }
            //}
            return dates;
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
    }
}
