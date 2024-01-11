namespace TemplateMethod
{
    internal class TrainingRegular : Training
    {
        #region Protected Methods

        protected override void MainPractice() => Console.WriteLine("Обшая тренировка на все группы мышц");

        protected override void Stretching() => Console.WriteLine("Усиленная растяжка");

        #endregion Protected Methods
    }
}