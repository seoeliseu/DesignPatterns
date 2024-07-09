using Builder.ConcretBuilder;
using Builder.Director;

var industriaBelica = new IndustriaBelica(new Ak47());
industriaBelica.MontarArma();

var ak47 = industriaBelica.ObterArma();
ak47.ArmaMontada();



//------------------------------------------------------------


industriaBelica = new IndustriaBelica(new M16());
industriaBelica.MontarArma();

var m16 = industriaBelica.ObterArma();
m16.ArmaMontada();

Console.ReadKey();



