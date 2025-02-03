using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Combien de chiffres voulez-vous additionner ? ");
            int n = int.Parse(Console.ReadLine());

            double[] chiffres = new double[n];
            double somme = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Entrez le chiffre {i + 1}: ");
                chiffres[i] = double.Parse(Console.ReadLine());
                somme += chiffres[i];
            }

            Console.WriteLine($"La somme des chiffres est: {somme}");
        }
    }
}
