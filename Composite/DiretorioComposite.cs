namespace Composite
{
    public class DiretorioComposite(string path) : IComponent
    {
        public string Path { get; set; } = path;
        public List<IComponent> Components { get; set; } = [];

        public void Adicionar(IComponent component)
        {
            Components.Add(component);
        }

        public void Remover(IComponent component)
        {
            Components.Remove(component);
        }

        public List<IComponent> Listar()
        {
            return Components;
        }

        public void Criptografar()
        {
            foreach (var component in Components)
            {
                component.Criptografar();
            }
        }
    }
}
