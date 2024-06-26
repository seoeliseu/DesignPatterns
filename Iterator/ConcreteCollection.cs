namespace Iterator
{
    public class ConcreteCollection : IIterableCollection
    {
        public ItemCollection? Root { get; set; }
        private ItemCollection? CurrentNode { get; set; }

        public ConcreteCollection(List<Fornecedor> fornecedores)
        {
            foreach (var fornecedor in fornecedores)
            {
                AddItem(fornecedor);
            }

            CurrentNode = Root;
        }

        private void AddItem(Fornecedor fornecedor)
        {
            if (Root == null)
            {
                Root = new ItemCollection(fornecedor);
                CurrentNode = Root;
                return;
            }

            if (CurrentNode == null)
            {
                CurrentNode = new ItemCollection(fornecedor);
            }
            else
            {
                if (CurrentNode.LeftNode == null)
                {
                    CurrentNode.LeftNode = new ItemCollection(fornecedor);
                }
                else if (CurrentNode.RightNode == null)
                {
                    CurrentNode.RightNode = new ItemCollection(fornecedor);
                }
                else
                {
                    CurrentNode = CurrentNode.LeftNode;
                    AddItem(fornecedor);
                }
                
            }
        }

        public IIterator GetIterator()
        {
            return new DepthFirstIterator(Root);
        }
    }
}
