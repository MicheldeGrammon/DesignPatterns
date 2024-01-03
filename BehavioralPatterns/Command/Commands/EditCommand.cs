namespace Command.Commands
{
    internal class EditCommand : ICommand
    {
        private readonly Document _document;

        public EditCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Edit();
        }
    }
}
