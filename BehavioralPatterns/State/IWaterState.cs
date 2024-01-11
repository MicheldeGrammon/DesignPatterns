namespace State
{
    internal partial class Program
    {
        #region Private Interfaces

        public interface IWaterState
        {
            #region Public Methods

            void Frost(Water water);

            void Heat(Water water);

            #endregion Public Methods
        }

        #endregion Private Methods
    }
}