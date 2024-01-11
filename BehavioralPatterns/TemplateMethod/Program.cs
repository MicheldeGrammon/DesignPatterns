namespace TemplateMethod
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            var leg = new TrainingLeg();
            var regular = new TrainingRegular();
            var gym = new Gym("Gold's Gym");

            gym.RunTraining(leg);
            gym.RunTraining(regular);
        }

        #endregion Private Methods
    }
}