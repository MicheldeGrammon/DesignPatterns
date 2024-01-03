namespace Strategy.Routes
{
    internal class WalkingBuilderRoute : IBuilderRoute
    {
        public void BuildRoute() => Console.WriteLine("Маршрут для пешехода построен");
    }
}
