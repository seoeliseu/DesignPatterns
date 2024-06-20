namespace Prototype.DeepCopy
{
    public class SoldadoDeepCopy : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public AcessorioDeepCopy Acessorio { get; set; }

        public SoldadoDeepCopy() { }

        public SoldadoDeepCopy(SoldadoDeepCopy s)
        {
            Nome = s.Nome;
            Acessorio = s.Acessorio;
            Arma = s.Arma;
        }

        public object Clone()
        {
            SoldadoDeepCopy soldado = (SoldadoDeepCopy)MemberwiseClone();
            soldado.Acessorio = (AcessorioDeepCopy)Acessorio.Clone();
            return soldado;
        }
    }
}
