using System;

namespace Singleton
{
    public class Utilisateur
    {
        static void Main(string[] args)
        {
            Vendeur vendeur1 = Vendeur.Instance();
            Vendeur vendeur2 = Vendeur.Instance();

            vendeur1.sales = 10;
            if(vendeur2.sales == vendeur1.sales)
                Console.WriteLine("Singleton fonctionnel");
            else
                Console.WriteLine("Singleton non fonctionnel");
        }
    }

}