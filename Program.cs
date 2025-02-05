using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stock stock = new Stock();
            Article article1 = new Article("1000", "nour", 1200, 2);
            Boolean test = false;

            while (test == false)
            {
                Console.WriteLine("1. Rechercher un article par référence. \n 2. Ajouter un article au stock en vérifiant l’unicité de la référence. \n 3. Supprimer un article par référence. \n 4. Afficher tous les articles. \n 5. Quitter");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        stock.RechercherArticle("1000");
                    break;
                    case 2:
                        stock.AjouterArticle(article1);
                    break;
                    case 3:
                        stock.SupprimerArticle("1000");
                    break;
                    case 4:
                        stock.AfficherArticles();
                    break;
                    case 5:
                        test = true;
                    break;
                }
            }
        }
    }
}
