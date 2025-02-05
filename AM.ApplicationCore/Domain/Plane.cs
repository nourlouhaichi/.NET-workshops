using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public ICollection<Flight> Flights { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlanneId { get; set; }
        public PlaneType PLaneType { get; set; }

        public override string ToString()
        {
            return "PlaneType: " + PLaneType + "ManufactureDate" + ManufactureDate + "Capacity" + Capacity;
        }

        public Plane(int capacity, DateTime manufactureDate, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }
    }
    public enum PlaneType
    {
        Boing,
        Airbus
    }
}
