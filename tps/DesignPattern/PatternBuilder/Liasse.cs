using System;
using System.Collections.Generic;

public abstract class Liasse
{
    protected IList<string> contenu =
        new List<string>();

    public abstract void ajouteDocument(string document);
    public abstract void imprime();
}