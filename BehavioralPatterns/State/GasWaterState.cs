namespace State
{
    internal partial class Program
    {
        #region Private Classes

        public class GasWaterState : IWaterState
        {
            #region Public Methods

            public void Frost(Water water)
            {
                Console.WriteLine("Превращаем водяной пар в жидкость");
                water.State = new LiquidWaterState();
            }

            public void Heat(Water water)
            {
                Console.WriteLine("Повышаем температуру водяного пара");
            }

            #endregion Public Methods
        }

        #endregion Private Methods
    }
}