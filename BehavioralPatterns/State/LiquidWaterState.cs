namespace State
{
    internal partial class Program
    {
        #region Private Classes

        public class LiquidWaterState : IWaterState
        {
            #region Public Methods

            public void Frost(Water water)
            {
                Console.WriteLine("Превращаем жидкость в лед");
                water.State = new SolidWaterState();
            }

            public void Heat(Water water)
            {
                Console.WriteLine("Превращаем жидкость в пар");
                water.State = new GasWaterState();
            }

            #endregion Public Methods
        }

        #endregion Private Methods
    }
}