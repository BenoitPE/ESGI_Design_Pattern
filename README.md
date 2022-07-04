# ESGI - Design Pattern en C#
###### tags: `Sciences U`, `ESGI`, `Design Pattern`, `.NET`, `C#`
###### date de dernière modification: `04/07/2022`

## Table des matières
[1. Abstract factory](#abstract-factory)
[2. Pattern Builder](#pattern-builder)
[3. Factory Method](#factory-method)

## Abstract Factory
`Abstract Factory` est un pattern qui aide à la création d'objet, le but est de regrouper les objets en famille sans avoir à connaitre les bases de ces objets.  

`Abstract Factory` va permettre de déresponsabiliser la classe mère. Pour cela, nous utilisons une interface qui va contenir des signatures de méthodes.  

Ici `FabriqueVehicule` est une interface qui contient deux signatures de méthodes `créeAutomobile()` et `créeScooter()`.  

La classe `Scooter` est une classe mère d'héritage, les classes filles `ScooterElectricité` et `ScooterEssence` utilisent `extends Scooter` pour étendre cette classe.  

### Version générique vue en cours
![Architecture de l'application](images/abstract_factory.png)

### Version concrète vue en cours
![Architecture de l'application](images/abstract_factory2.png)

Dans le second schéma, version générique du pattern, les structures sont affichées de façon plus générique
`FabriqueConcrète1` et `FabriqueConcrète2` correspondraient à `FabriqueVéhiculeElectricité` et `FabriqueVehiculeEssence`.  

`ProduitAbstraitA` correspond à scooter et `ProduitAbstraitB` à `Automobile`.  

## Pattern Builder

Création d'objets complexes sans avoir à s'occuper des problèmes d'implémentations
### Version générique vue en cours
<img src="images/pattern_builder.png">

### Version concrète vue en cours
<img src="images/pattern_builder_2.png">

Ce pattern est utilisé pour séparer l'implémentation d'un cas spécifique de la logique/ du client.

Un client (utilisateur physique ou logiciel) a besoin de construire des objets complexes sans connaître son implémentation.  
Construire des objets complexes ayant plusieurs implémentations.  

## Factory method

Généraliser la construction
`Builder` pour préparer la création d'objet

### Version générique vue en cours
<img src="images/factory_method_2.png">

### Version concrète vue en cours
<img src="images/factory_method.png">

## Singleton