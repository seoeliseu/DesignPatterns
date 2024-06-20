namespace Prototype
{
    public class AcessorioDeepCopy
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return (AcessorioDeepCopy)this.MemberwiseClone();
        }
    }
}
