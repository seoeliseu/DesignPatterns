namespace Prototype.DeepCopy
{
    public class AcessorioDeepCopy
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return (AcessorioDeepCopy)MemberwiseClone();
        }
    }
}
