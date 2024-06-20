namespace Prototype
{
    public class SoldadoDeepCopy : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public AcessorioDeepCopy Acessorio { get; set; }

        public SoldadoDeepCopy() { }

        public SoldadoDeepCopy(SoldadoDeepCopy s)
        {
            this.Nome = s.Nome;
            this.Acessorio = s.Acessorio;
            this.Arma = s.Arma;
        }

        public object Clone()
        {
            SoldadoDeepCopy soldado =  (SoldadoDeepCopy)this.MemberwiseClone();
            soldado.Acessorio = (AcessorioDeepCopy)this.Acessorio.Clone();
            return soldado;
        }
    }
}
