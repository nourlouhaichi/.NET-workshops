using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public List<DateTime> GetFlightDates(string destination);
        public void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        public IEnumerable<Flight> OrderedDurationFlights();
        List<Traveller> SeniorTravellers(Flight flight);
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}
