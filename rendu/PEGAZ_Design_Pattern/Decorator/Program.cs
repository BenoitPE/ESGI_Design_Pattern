using Decorator;
using Common;

var description = @"
We want to define the encapsulation of several elements.
In our case, we want to have a City in a Department in a Region in a Country.
For this we used the structural design pattern Decorator
";

UI.printCopyright("Decorator", description);

CountryView countryView = new CountryView();
RegionDecorator regionDecorator = new RegionDecorator(countryView);
DepartmentDecorator departmentDecorator = new DepartmentDecorator(regionDecorator);
CityDecorator cityDecorator = new CityDecorator(departmentDecorator);
cityDecorator.printInformations();

Console.ReadKey();