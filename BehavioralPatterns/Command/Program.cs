using Command.Commands;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Создание необходимых объектов
            var document = new Document();

            var openCommand = new OpenCommand(document);
            var editCommand = new EditCommand(document);
            var saveCommand = new SaveCommand(document);
            var closeCommand = new CloseCommand(document);

            var menuOprions = new MenuOptions(openCommand, editCommand, saveCommand, closeCommand);


            //Выдача команд(управление)
            menuOprions.ClickOpen();
            menuOprions.ClickEdit();
            menuOprions.ClickSave();
            menuOprions.ClickClose();

        }
    }
}