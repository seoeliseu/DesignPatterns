namespace Iterator
{
    public class Fornecedor(int id, string nome, string endereco, string bairro, string cidade)
    {
        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public string Endereco { get; set; } = endereco;
        public string Bairro { get; set; } = bairro;
        public string Cidade { get; set; } = cidade;
    }
}
