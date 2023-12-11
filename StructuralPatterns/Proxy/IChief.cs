namespace Proxy
{
    public interface IChief
    {
        public IEnumerable<Order> GetOrders();
        public IDictionary<int, string> GetStatuses();
    }
}