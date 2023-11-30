using Builder.Pilafs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class SamarkandBuilder : PilafBuilder
    {
        public override void SetCarrot()
        {
            Pilaf.Carrot = new Carrot();
        }

        public override void SetMeat()
        {
            Pilaf.Meat = new Meat() { Type = "Говядина + Баранина" };
        }

        public override void SetRice()
        {
            Pilaf.Rice = new Rice() { Sort = "Рис Басмати" };
        }
    }
}
