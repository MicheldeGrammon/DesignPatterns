namespace State
{
    internal partial class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();
            water.Frost();
            water.Frost();

            Console.Read();
        }

        #endregion Private Methods
    }
}