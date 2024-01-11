namespace TemplateMethod
{
    internal class Gym
    {
        #region Public Properties

        public string Name { get; set; }

        #endregion Public Properties

        #region Public Constructors

        public Gym(string name)
        {
            Name = name;
        }

        #endregion Public Constructors

        #region Public Methods

        public void RunTraining(Training training) => training.Run();

        #endregion Public Methods
    }
}