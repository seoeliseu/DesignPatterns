namespace Iterator
{
    public class ItemCollection(Fornecedor fornecedor)
    {
        public Fornecedor Fornecedor { get; set; } = fornecedor;
        public ItemCollection? LeftNode { get; set; }
        public ItemCollection? RightNode { get; set; }
    }
}
