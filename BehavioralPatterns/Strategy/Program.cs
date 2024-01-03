using Strategy.Routes;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carBuilderRoute = new CarBuilderRoute();
            var walkingBuilderRoute = new WalkingBuilderRoute();
            var navigator = new Navigator("any parameters", walkingBuilderRoute);

            navigator.GetRoute();

            //смена выбора построения алгоритма маршурта
            navigator.BuilderRoute = carBuilderRoute;

            navigator.GetRoute();
        }
    }
}
