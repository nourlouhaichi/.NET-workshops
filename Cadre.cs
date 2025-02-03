using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cadre : Employee
    {
        public int Indice {  get; set; }

        public Cadre(string matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            Indice = indice;
        }

        public override double GetSalaire()
        {
            if (Indice == 1) { return 1300; }
            else if (Indice == 2) { return 1500; }
            else if (Indice == 3) { return 1700; }
            else if (Indice == 4) { return 2000; }
            else throw new ArgumentException("Indice invalide");
        }

        public override string ToString()
        {
            return base.ToString() + $", Indice: {Indice}, Salaire: {GetSalaire()} D";
        }
    }
}
