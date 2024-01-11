namespace TemplateMethod
{
    internal abstract class Training
    {
        #region Public Methods

        public void Run()
        {
            Warm();
            MainPractice();
            Stretching();
            Shower();
        }

        #endregion Public Methods

        #region Protected Methods

        protected abstract void MainPractice();

        protected virtual void Stretching() => Console.WriteLine("Растяжка");

        #endregion Protected Methods

        #region Private Methods

        public void Warm() => Console.WriteLine("Разминка (разогрев перед тренировкой)");

        private void Shower() => Console.WriteLine("Принимаем душ");

        #endregion Private Methods
    }
}