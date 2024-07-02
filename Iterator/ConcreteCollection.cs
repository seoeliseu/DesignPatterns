namespace Iterator
{
    public class ConcreteCollection : IIterableCollection
    {
        public ItemCollection? Root { get; set; }

        public ConcreteCollection(List<Fornecedor> fornecedores)
        {
            foreach (var fornecedor in fornecedores)
            {
                AddItem(fornecedor);
            }

            BalanceTree();
        }

        private void AddItem(Fornecedor fornecedor)
        {
            if (Root == null)
            {
                Root = new ItemCollection(fornecedor);
                return;
            }

            Queue<ItemCollection> queue = new();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                ItemCollection currentNode = queue.Dequeue();

                if (currentNode.LeftNode == null)
                {
                    currentNode.LeftNode = new ItemCollection(fornecedor);
                    return;
                }
                else
                {
                    queue.Enqueue(currentNode.LeftNode);
                }

                if (currentNode.RightNode == null)
                {
                    currentNode.RightNode = new ItemCollection(fornecedor);
                    return;
                }
                else
                {
                    queue.Enqueue(currentNode.RightNode);
                }
            }
        }
        
        public IIterator GetIterator()
        {
            return new AVLSearchIterator(Root);
        }

        private void BalanceTree()
        {
            var nodes = new List<ItemCollection>();
            CollectNodes(Root, nodes);

            // Ordenar os nós pelo Id do Fornecedor
            nodes.Sort((a, b) => a.Fornecedor.Id.CompareTo(b.Fornecedor.Id));

            Root = BuildBalancedTree(nodes, 0, nodes.Count - 1);
        }

        private void CollectNodes(ItemCollection? node, List<ItemCollection> nodes)
        {
            if (node == null) return;
            CollectNodes(node.LeftNode, nodes);
            nodes.Add(node);
            CollectNodes(node.RightNode, nodes);
        }

        private ItemCollection? BuildBalancedTree(List<ItemCollection> nodes, int start, int end)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;
            ItemCollection node = nodes[mid];

            node.LeftNode = BuildBalancedTree(nodes, start, mid - 1);
            node.RightNode = BuildBalancedTree(nodes, mid + 1, end);

            return node;
        }

    }
}
