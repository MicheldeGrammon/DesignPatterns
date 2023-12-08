namespace Decorator.Shaurms
{
    internal abstract class Shaurma
    {
        public string Name { get; set; }

        public Shaurma(string name)
        {
            Name = name;
        }
        public abstract int GetCost();
    }
}
