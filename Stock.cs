using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Stock
    {
        public List<Article> liste = new List<Article>();


        public Article RechercherArticle(string reference)
        {
            foreach (Article article in liste)
            {
                if (article.reference == reference)
                {
                    Console.WriteLine(article);
                    return article;
                }
            }
            return null;
        }

        public bool AjouterArticle(Article article)
        {
            if (RechercherArticle(article.reference) == null)
            {
                liste.Add(article);
                return true; 
            }
            return false;
        }

        public bool SupprimerArticle(string reference)
        {
            Article article = RechercherArticle(reference);
            if (article != null)
            {
                liste.Remove(article);
                return true; 
            }
            return false; 
        }

        public void AfficherArticles()
        {
            foreach (Article article in liste)
            {
                Console.WriteLine(article);
            }
        }
    }
}
