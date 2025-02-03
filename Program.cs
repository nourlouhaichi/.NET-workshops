using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patron.Chiffre = 100000; 

            Cadre cadre1 = new Cadre("C001", "Dupont", "Jean", new DateTime(1985, 5, 12), 3);
            Patron patron1 = new Patron("P001", "Martin", "Sophie", new DateTime(1970, 8, 25), 10);

            Console.WriteLine(cadre1);
            Console.WriteLine(patron1);
        }
    }
}
