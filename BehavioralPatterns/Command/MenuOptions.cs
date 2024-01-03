using Command.Commands;

namespace Command
{
    internal class MenuOptions
    {
        private readonly ICommand _openCommand;
        private readonly ICommand _editCommand;
        private readonly ICommand _saveCommand;
        private readonly ICommand _closeCommand;

        public MenuOptions(ICommand openCommand, ICommand editCommand, ICommand saveCommand, ICommand closeCommand)
        {           
            _openCommand = openCommand;
            _editCommand = editCommand;
            _saveCommand = saveCommand;
            _closeCommand = closeCommand;
        }

        public void ClickOpen() => _openCommand.Execute();

        public void ClickEdit() => _editCommand.Execute();

        public void ClickSave() => _saveCommand.Execute();

        public void ClickClose() => _closeCommand.Execute();
    }
}
