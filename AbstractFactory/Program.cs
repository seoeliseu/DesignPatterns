using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory.AbstractFactory;


//obtem as fabricas
var boloFactory = MassasAbstractFactory.CriarFabricaDeMassas(TipoMassa.Bolo);
var pizzaFactory = MassasAbstractFactory.CriarFabricaDeMassas(TipoMassa.Pizza);

//cri os objetos com base no tipo : bolo

var bolo1 = boloFactory.CriarMassa((TipoMassa)TipoBolo.Morango);
var bolo2 = boloFactory.CriarMassa((TipoMassa)TipoBolo.Chocolate);

//cri os objetos com base no tipo : pizza

var pizza1 = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Calabresa);
var pizza2 = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Mussarela);

//exibe os detalhes 
ExibirDetalhes(bolo1);
ExibirDetalhes(bolo2);
ExibirDetalhes(pizza1);
ExibirDetalhes(pizza2);




static void ExibirDetalhes(MassaBase massa)
{
    Console.WriteLine($"Massa: {massa.Nome}");
    Console.WriteLine($"Tipo: {massa.TipoMassa}");
    Console.WriteLine();
}
