# ESGI - Design Pattern en C#
###### tags: `Sciences U`, `ESGI`, `Design Pattern`, `.NET`, `C#`
###### date de dernière modification: `04/07/2022`

## Abstract Factory
`Abstract Factory` est un pattern qui aide à la création d'objet, le but est de regrouper les objets en famille sans avoir à connaitre les bases de ces objets.  

`Abstract Factory` va permettre de déresponsabiliser la classe mère. Pour cela, nous utilisons une interface qui va contenir des signatures de méthodes.  

![Architecture de l'application](images/abstract_factory.png)

Ici `FabriqueVehicule` est une interface qui contient deux signatures de méthodes `créeAutomobile()` et `créeScooter()`.  

La classe `Scooter` est une classe mère d'héritage, les classes filles `ScooterElectricité` et `ScooterEssence` utilisent `extends Scooter` pour étendre cette classe.  

![Architecture de l'application](images/abstract_factory2.png)

Dans le second schéma, version générique du pattern, les structures sont affichées de façon plus générique
`FabriqueConcrète1` et `FabriqueConcrète2` correspondraient à `FabriqueVéhiculeElectricité` et `FabriqueVehiculeEssence`.  

`ProduitAbstraitA` correspond à scooter et `ProduitAbstraitB` à `Automobile`.  

## Pattern Builder

Création d'objets complexes sans avoir à s'occuper des problèmes d'implémentations

<img src="images/pattern_builder.png">

<img src="images/pattern_builder_2.png">

Ce pattern est utilisé pour séparer l'implémentation d'un cas spécifique de la logique/ du client.

Un client (utilisateur physique ou logiciel) a besoin de construire des objets complexes sans connaître son implémentation.  
Construire des objets complexes ayant plusieurs implémentations.  

## Factory method

Généraliser la construction
`Builder` pour préparer la création d'objet

<img src="images/factory_method.png">
