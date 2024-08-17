namespace Proxy
{
    public class Funcionario(string nome, string senha, string perfil)
    {
        public string Nome { get; set; } = nome;
        public string Senha { get; set; } = senha;
        public string Perfil { get; set; } = perfil;
    }
}
