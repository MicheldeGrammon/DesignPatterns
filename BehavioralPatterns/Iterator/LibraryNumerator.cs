namespace Iterator
{
    public class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index = 0;

        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext() => index < aggregate.Count;

        public Book Next() => aggregate[index++];
    }
}
