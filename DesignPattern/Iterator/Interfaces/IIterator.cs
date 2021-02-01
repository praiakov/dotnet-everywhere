namespace Iterator.Interfaces
{
    public interface IIterator
    {
        object First();
        object Next();
        object Current();
        int GetIndex();
    }
}