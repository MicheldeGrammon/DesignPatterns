namespace Decorator.Shaurms
{
    internal class StandartShaurma : Shaurma
    {
        public StandartShaurma() : base("Стандартная шаурма")
        {

        }

        public override int GetCost() => 200;
    }
}
