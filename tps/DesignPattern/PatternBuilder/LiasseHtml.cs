using System;

public class LiasseHtml : Liasse
{
    public override void ajouteDocument(string document)
    {
        if (document.StartsWith("<HTML>"))
            contenu.Add(document);
    }

    public override void imprime()
    {
        Console.WriteLine("Liasse HTML");
        foreach (string s in contenu)
            Console.WriteLine(s);
    }
}