namespace Command
{
    internal class Document
    {
        public void Open() => Console.WriteLine("Document Opened");

        public void Edit() => Console.WriteLine("Document Edited");

        public void Save() => Console.WriteLine("Document Saved");

        public void Close() => Console.WriteLine("Document Closed");

    }
}
