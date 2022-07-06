using System;

public class FormImmatriculationFrance : FormulaireImmatriculation
{
  public FormImmatriculationFrance(IFormulaireImpl implantation) : base(implantation){}

  protected override bool controleSaisie(string plaque)
  {
    return plaque.Length == 7;
  }
}
