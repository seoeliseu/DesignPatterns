namespace Iterator
{
    public class AVLSearchIterator : IIterator
    {
        public ItemCollection Root { get; private set; }

        public AVLSearchIterator(ItemCollection root)
        {
            Root = root;
        }

        public Fornecedor? First(int id)
        {
            while (HasNext())
            {
                var item = Next();

                Console.WriteLine($"Fornecedor: {item.Fornecedor.Id}");

                if (item.Fornecedor.Id == id)
                    return item.Fornecedor;

                if (item.Fornecedor.Id > id)
                    Root = item.LeftNode;
                else
                    Root = item.RightNode;
            }

            return null;
        }

        public bool HasNext()
        {
            return Root.LeftNode != null || Root.RightNode != null;
        }

        public ItemCollection Next()
        {
            return Root;
        }
    }
}
