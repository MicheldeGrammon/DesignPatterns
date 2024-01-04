namespace Iterator
{
    public class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
            new Book{Name="Чистый код"},
            new Book {Name="Идеальный программист"},
            new Book {Name="Чистая архитектура"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator() => new LibraryNumerator(this);
    }
}
