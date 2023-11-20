using FactoryMethods.AtHome;

namespace FactoryMethod.Developers
{
    public abstract partial class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        public abstract House Create();
    }
}