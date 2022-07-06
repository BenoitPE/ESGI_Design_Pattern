using System;

public class FormAppletImpl : IFormulaireImpl
{

  public void dessineTexte(string texte)
  {
    Console.WriteLine("Applet : " + texte);
  }

  public string gereZoneSaisie()
  {
    return Console.ReadLine();
  }
}
