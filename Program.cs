using Builder;

var director = new GadgetDirector(new GalaxyBuilder());

director.MakePhone();

var phone = director.GetSmartPhone();

Console.WriteLine($"Marca: {phone.Brand} - Cor: {phone.Color} - Nome: {phone.Name} - Preco: {phone.Price} - Tela: {phone.Screen}");