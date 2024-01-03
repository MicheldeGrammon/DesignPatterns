namespace Command.Commands
{
    internal class CloseCommand : ICommand
    {
        private readonly Document _document;

        public CloseCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Close();
        }
    }
}
