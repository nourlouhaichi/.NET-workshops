using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Employee
    {
        public Employee(string matricule, string nom, string prenom, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public  DateTime  DateNaissance{ get; set; }

        public override string ToString()
        {
            return $"Matricule: {Matricule}, Nom: {Nom}, Prénom: {Prenom}, Date de naissance: {DateNaissance.ToShortDateString()}";
        }

        public abstract double GetSalaire();
        
    }
}
