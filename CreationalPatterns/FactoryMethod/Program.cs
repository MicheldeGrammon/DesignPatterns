using FactoryMethod.Developers;
using FactoryMethods.AtHome;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house1 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house2 = dev.Create();
        }
    }
}