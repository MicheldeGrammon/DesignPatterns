namespace TemplateMethod
{
    internal class TrainingLeg : Training
    {
        #region Protected Methods

        protected override void MainPractice() => Console.WriteLine("Тренировка ног");

        #endregion Protected Methods
    }
}