using Prototype;


//Exemplo shallou copy prototype não temos a copia  do valor acessorio e sim da refarencia do objeto acessorio

Console.WriteLine("Exemplo shallow copy prototype\n");

SoldadoShallowCopy soldadoShallowCopyOriginal = new()
{
    Nome = "Kaio schmidt",
    Arma = "Fuzil",
    Acessorio = new AcessorioShallowCopy { Nome = "Visão noturna" }
};

SoldadoShallowCopy soldadoShallowCopy = (SoldadoShallowCopy)soldadoShallowCopyOriginal.Clone();
soldadoShallowCopy.Nome = "Eliseu";
soldadoShallowCopy.Arma = "Pistola";
soldadoShallowCopy.Acessorio.Nome = "Lanterna";

Console.WriteLine("Objeto Original");
Console.WriteLine($"{soldadoShallowCopyOriginal.Nome} - {soldadoShallowCopyOriginal.Arma}");
Console.WriteLine($"{soldadoShallowCopyOriginal.Acessorio.Nome}\n");

Console.WriteLine(">> Objeto clone");
Console.WriteLine($"{soldadoShallowCopy.Nome} - {soldadoShallowCopy.Arma}");
Console.WriteLine($"{soldadoShallowCopy.Acessorio.Nome}\n");


// exemplo deep copy prototype copiamos a referencia do objeto acessorio e seu valor

Console.WriteLine("Exemplo deep copy prototype\n");

SoldadoDeepCopy soldadoDeepCopyOriginal = new()
{
    Nome = "Kaio schmidt",
    Arma = "Fuzil",
    Acessorio = new AcessorioDeepCopy { Nome = "Visão noturna" }
};

SoldadoDeepCopy soldadoDeepCopy = (SoldadoDeepCopy)soldadoDeepCopyOriginal.Clone();
soldadoDeepCopy.Nome = "Eliseu";
soldadoDeepCopy.Arma = "Pistola";
soldadoDeepCopy.Acessorio.Nome = "Lanterna";

Console.WriteLine("Objeto Original");
Console.WriteLine($"{soldadoDeepCopyOriginal.Nome} - {soldadoDeepCopyOriginal.Arma}");
Console.WriteLine($"{soldadoDeepCopyOriginal.Acessorio.Nome}\n");

Console.WriteLine(">> Objeto clone");
Console.WriteLine($"{soldadoDeepCopy.Nome} - {soldadoDeepCopy.Arma}");
Console.WriteLine($"{soldadoDeepCopy.Acessorio.Nome}\n");


Console.ReadKey();



