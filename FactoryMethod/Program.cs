using FactoryMethod;

Console.WriteLine("---------------------------Pizzaria Schmidt------------------------------------");

Console.WriteLine("Informe local SP para são paulo e RJ para Rio de Janeiro ");

var cidadeEscolhida = Console.ReadLine().ToUpper();

Console.WriteLine("Informe o sabor da pizza: Calabresa ou Mussarela");

var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
	PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaFactory(cidadeEscolhida);
	var pizza = pizzaria.MontarPizza(pizzaEscolhida);
	Console.WriteLine(pizza.Preparar());
	Console.WriteLine("\n Pizza pronta!");
}
catch (Exception ex)
{
	Console.WriteLine("Erro: " + ex.Message);
	throw;
}
