namespace Decorator.Shaurms
{
    internal class MiniShaurma : Shaurma
    {
        public MiniShaurma() : base("Мини-шаурма")
        {

        }

        public override int GetCost() => 150;
    }
}
