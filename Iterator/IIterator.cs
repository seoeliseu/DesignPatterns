namespace Iterator
{
    public interface IIterator
    {
        Fornecedor? First(int id);
        bool HasNext();
        ItemCollection Next();
    }
}
