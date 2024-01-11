namespace Observer
{
    internal class ControlledDevice : IObservable
    {
        #region Public Fields

        public Metrics metrics;

        #endregion Public Fields

        #region Private Fields

        private List<IObserver> observers;

        #endregion Private Fields

        #region Public Constructors

        public ControlledDevice()
        {
            observers = new List<IObserver>();
            metrics = new Metrics();
        }

        #endregion Public Constructors

        #region Public Methods

        public void ImitationWork()
        {
            Random rnd = new Random();
            metrics.Temperature = rnd.Next(30, 100);
            metrics.Availability = rnd.Next(2) == 0 ? false : true;

            Notify();
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(metrics);
            }
        }

        public void Register(IObserver observer) => observers.Add(observer);

        public void Remove(IObserver observer) => observers.Remove(observer);

        #endregion Public Methods
    }
}