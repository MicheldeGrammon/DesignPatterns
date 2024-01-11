namespace State
{
    internal partial class Program
    {
        #region Private Classes

        public class Water
        {
            #region Public Properties

            public IWaterState State { get; set; }

            #endregion Public Properties

            #region Public Constructors

            public Water(IWaterState ws)
            {
                State = ws;
            }

            #endregion Public Constructors

            #region Public Methods

            public void Frost()
            {
                State.Frost(this);
            }

            public void Heat()
            {
                State.Heat(this);
            }

            #endregion Public Methods
        }

        #endregion Private Methods
    }
}