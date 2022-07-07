using AbstractFactory;
using Common;

string description = @"
We have an application that manages the arrival of animals at the SPA. 
The goal of the Abstract Factory design pattern is to group objects into families without having to know the basics of these objects.
";
string details = "Here the two concrete factories are 'DomesticAnimal' and 'WildAnimal'.";

UI.printCopyright("Abstract Factory", description, details);

IAnimal domesticAnimal = new DomesticAnimal();
Feline cat = domesticAnimal.addFeline("Cat");
cat.printAnimal();

Reptile lizard  = domesticAnimal.addReptile("Lizard");
lizard.printAnimal();

IAnimal wildAnimal = new WildAnimal();
Feline tiger = wildAnimal.addFeline("Tiger");
tiger.printAnimal();

Reptile komodoDragon = wildAnimal.addReptile("Komodo Dragon");
komodoDragon.printAnimal();
