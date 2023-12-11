namespace Proxy
{
    internal class Chief : IChief
    {
        //В данном примере получение статусов через метод выглядит надуманно. Но очень показательно, для работы паттерна в качестве кеширования
        //Sleep имитация зависания получения статусов
        public IDictionary<int, string> GetStatuses()
        {
            var statuses = new Dictionary<int, string>();

            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            Thread.Sleep(2000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = new List<Order>();

            orders.Add(new Order() { Name = "Burger", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Pasta", StatusId = RandomizeStatus() });
            orders.Add(new Order() { Name = "Omelet", StatusId = RandomizeStatus() });

            return orders;
        }

        private int RandomizeStatus() => new Random().Next(1, 4);
    }
}
