using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public ICollection<Flight> Flights { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public String EmailAdress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public long TelNumber { get; set; }

        public override string ToString()
        {
            return "PassportNumber: " + PassportNumber + "FirstName" + FirstName + "LastName" + LastName;
        }

        public bool CheckProfile(string name, string lastname)
        {
            return name == FirstName && lastname == LastName;
        }
        public bool CheckProfile(string name, string lastname, string email)
        {
            return name == FirstName && lastname == LastName && email == EmailAdress;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am Passenger");
        }

    }
}
