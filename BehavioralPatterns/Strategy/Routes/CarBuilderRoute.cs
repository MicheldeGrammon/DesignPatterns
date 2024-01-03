namespace Strategy.Routes
{
    internal class CarBuilderRoute : IBuilderRoute
    {
        public void BuildRoute() => Console.WriteLine("Марштур для автомобиля построен");
    }
}
