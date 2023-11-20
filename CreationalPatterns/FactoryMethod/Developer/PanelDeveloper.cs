using FactoryMethods.AtHome;

namespace FactoryMethod.Developers
{
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}