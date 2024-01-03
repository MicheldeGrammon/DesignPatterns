namespace Command.Commands
{
    internal class OpenCommand : ICommand
    {
        private readonly Document _document;

        public OpenCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Open();
        }
    }
}
