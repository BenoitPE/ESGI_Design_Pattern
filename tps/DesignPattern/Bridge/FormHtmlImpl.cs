using System;

public class FormHtmlImpl : IFormulaireImpl
{

  public void dessineTexte(string texte)
  {
    Console.WriteLine("HTML : " + texte);
  }

  public string gereZoneSaisie()
  {
    return Console.ReadLine();
  }
}
