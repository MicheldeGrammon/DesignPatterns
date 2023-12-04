
namespace Adapter
{
    internal class StreetCleanerAdapter : IWorker
    {
        private readonly StreetCleaner _streetCleaner = new StreetCleaner();

        public void RunWork()
        {
            _streetCleaner.RunCleaning();
        }
    }
}
