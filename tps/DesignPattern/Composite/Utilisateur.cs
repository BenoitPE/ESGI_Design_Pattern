using System;

public class Utilisateur
{
    static void Main(string[] args)
    {
        Societe societe1 = new SocieteSansFiliale();
        societe1.ajouteVehicule();

        Societe societe2 = new SocieteSansFiliale();
        societe2.ajouteVehicule();
        societe2.ajouteVehicule();

        Societe societe3 = new SocieteMere();
        societe3.ajouteVehicule();
        societe3.ajouteFiliale(societe2);

        Societe groupe = new SocieteMere();
        groupe.ajouteFiliale(societe1);

        groupe.ajouteVehicule();

        Console.WriteLine(" Coût d'entretien total du groupe : " + groupe.calculeCoutEntretien());
    }
}
