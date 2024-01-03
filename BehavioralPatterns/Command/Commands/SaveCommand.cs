namespace Command.Commands
{
    internal class SaveCommand : ICommand
    {
        private readonly Document _document;

        public SaveCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Save();
        }
    }
}
