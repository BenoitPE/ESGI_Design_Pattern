public class CatalogueVehicule : Catalogue<Vehicule,
  IterateurVehicule> 
{

  public CatalogueVehicule()
  {
    contenu.Add(new Vehicule("v�hicule bon march�"));
    contenu.Add(new Vehicule("petit v�hicule bon march�"));
    contenu.Add(new Vehicule("v�hicule grande qualit�"));
  }
}
