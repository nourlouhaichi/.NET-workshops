using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Article
    {
        public Article(string reference, string nom, double prix, int quantite)
        {
            this.reference = reference;
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
        }

        public string reference { get; set; }
        public string nom { get; set; }
        public double prix { get; set; }
        public int quantite { get; set; }

        public override string ToString()
        {
            return $"Articlee: {reference}, Nom: {nom}, Prix: {prix}, Quantite: {quantite}";
        }

    }
     
    }
