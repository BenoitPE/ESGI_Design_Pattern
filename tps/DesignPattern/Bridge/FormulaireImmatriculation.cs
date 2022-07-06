using System;

public abstract class FormulaireImmatriculation
{
  protected string contenu;
  protected IFormulaireImpl implantation;

  public FormulaireImmatriculation(IFormulaireImpl
    implantation)
  {
    this.implantation = implantation;
  }

  public void affiche()
  {
    implantation.dessineTexte(
      "num�ro de la plaque existante : ");
  }

  public void genereDocument()
  {
    implantation.dessineTexte("Demande d'immatriculation");
    implantation.dessineTexte("num�ro de plaque : " +
      contenu);
  }

  public bool gereSaisie()
  {
    contenu = implantation.gereZoneSaisie();
    return this.controleSaisie(contenu);
  }

  protected abstract bool controleSaisie(string plaque);
}
