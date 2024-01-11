namespace State
{
    internal partial class Program
    {
        #region Private Classes

        public class SolidWaterState : IWaterState
        {
            #region Public Methods

            public void Frost(Water water)
            {
                Console.WriteLine("Продолжаем заморозку льда");
            }

            public void Heat(Water water)
            {
                Console.WriteLine("Превращаем лед в жидкость");
                water.State = new LiquidWaterState();
            }

            #endregion Public Methods
        }

        #endregion Private Classes
    }
}