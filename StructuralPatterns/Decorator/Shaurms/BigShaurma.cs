namespace Decorator.Shaurms
{
    internal class BigShaurma : Shaurma
    {
        public BigShaurma() : base("Богатырская шаурма")
        {

        }

        public override int GetCost() => 250;
    }
}
