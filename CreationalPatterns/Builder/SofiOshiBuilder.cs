using Builder.Pilafs;

namespace Builder
{
    internal class SofiOshiBuilder : PilafBuilder
    {
        public override void SetCarrot()
        {
            Pilaf.Carrot = new Carrot();
        }

        public override void SetMeat()
        {
            Pilaf.Meat = new Meat() { Type = "Варенная говядина" };
        }

        public override void SetRice()
        {
            Pilaf.Rice = new Rice() { Sort="Рис Лазер" };
        }
    }
}
