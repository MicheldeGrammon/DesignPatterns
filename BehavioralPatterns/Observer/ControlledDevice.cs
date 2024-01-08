namespace Observer
{
    internal class ControlledDevice : IObservable
    {
        public Metrics metrics;
        List<IObserver> observers;

        public ControlledDevice()
        {
            observers = new List<IObserver>();
            metrics = new Metrics();
        }

        public void Notify()
        {
            foreach(var observer in observers) 
            {
                observer.Update(metrics);
            }
        }

        public void Register(IObserver observer) => observers.Add(observer);

        public void Remove(IObserver observer) => observers.Remove(observer);

        public void ImitationWork()
        {
            Random rnd = new Random();
            metrics.Temperature = rnd.Next(30, 100);
            metrics.Availability = rnd.Next(2) == 0 ? false : true;

            Notify();
        }
    }
}
