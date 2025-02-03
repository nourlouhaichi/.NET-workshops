using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Patron : Employee
    {
        public static double Chiffre { get; set; }
        public double Pourcentage { get; set; }

        public Patron(string matricule, string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
        {
            Pourcentage = pourcentage;
        }

        public override double GetSalaire()
        {
            return Chiffre * Pourcentage / 100;

        }

        public override string ToString()
        {
            return base.ToString() + $", Pourcentage: {Pourcentage}%, Salaire: {GetSalaire()} D";
        }
    }
}
