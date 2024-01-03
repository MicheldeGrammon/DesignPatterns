using Strategy.Routes;

namespace Strategy
{
    internal class Navigator
    {
        private string _anyParametrs;
        public IBuilderRoute BuilderRoute { private get; set; }

        public Navigator(string anyParametrs, IBuilderRoute builderRoute)
        {
            _anyParametrs = anyParametrs;
            BuilderRoute = builderRoute;
        }

        public void GetRoute()
        {
            BuilderRoute.BuildRoute();
        }
    }
}
