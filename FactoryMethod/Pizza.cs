using System.Text;

namespace FactoryMethod
{
    // Product
    public abstract class Pizza
    {
        protected string Nome;
        protected string Massa;
        protected string Molho;
        protected List<string> Ingredientes = new List<string>();

        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Preparando a pizza {Nome}");
            sb.AppendLine($"Abra a massa");
            sb.AppendLine($"Adicione o molho");
            sb.AppendLine($"Adicione os ingredientes:");
            foreach (var item in Ingredientes)
            {
                sb.AppendLine(item);
            }
            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());
            return sb.ToString();
        }

        public virtual string Cozinhar()
        {
            return "Cozinhe por 25 minutos a 350 graus";
        }
        public virtual string Fatiar() 
        {
            return "Corte a pizza em fatias diagonais";
        }
        public virtual string Embalar()
        {
            return "Coloque a pizza na caixa oficial da pizzaria";
        }

    }
}
