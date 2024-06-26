namespace Iterator
{
    public class DepthFirstIterator : IIterator
    {
        private readonly Stack<ItemCollection> stack = new();

        public DepthFirstIterator(ItemCollection? root)
        {
            if (root != null)
            {
                stack.Push(root);
            }
        }

        public Fornecedor? First(int id)
        {
            while (HasNext())
            {
                var item = Next();

                Console.WriteLine($"Fornecedor: {item.Fornecedor.Id}");

                if (item.Fornecedor.Id == id)
                    return item.Fornecedor;
            }

            return null;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public ItemCollection Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more elements in the iterator.");
            }

            var currentNode = stack.Pop();
            if (currentNode.RightNode != null)
            {
                stack.Push(currentNode.RightNode);
            }

            if (currentNode.LeftNode != null)
            {
                stack.Push(currentNode.LeftNode);
            }

            return currentNode;
        }
    }
}
