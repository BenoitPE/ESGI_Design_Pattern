using Bridge;
using Common;

string description = @"
In our application we have three types of TVs: LED, QLED and LCD. We also have two types of remote controls.
If we want to add a new type of TV  or a new remote control, to avoid an exponential increase in the number of classes we use the 'Bridge' structural design pattern.
";
string details = "The remote controls represent the 'Abstraction' part and the televisions represent the 'Implementation' part";

UI.printCopyright("Bridge", description, details);

Console.WriteLine();
SamsungRemote samsungRemote = new SamsungRemote(new LEDTelevision());
samsungRemote.SwitchOn();
samsungRemote.SetChannel(2);
samsungRemote.SwitchOff();

Console.WriteLine();
PanasonicRemote panasonicRemote = new PanasonicRemote(new LCDTelevision());
panasonicRemote.SwitchOn();
panasonicRemote.SetChannel(1);
panasonicRemote.SwitchOff();

Console.WriteLine();
SamsungRemote samsungRemote2 = new SamsungRemote(new QLEDTelevision());
samsungRemote2.SwitchOn();
samsungRemote2.SetChannel(3);
samsungRemote2.SwitchOff();

Console.ReadKey();