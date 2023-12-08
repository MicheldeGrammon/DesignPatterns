using Decorator.Shaurms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class ChickenShaurma : DecoratorShaurma
    {
        public ChickenShaurma(Shaurma shaurma) : base($"{shaurma.Name} c курицей", shaurma)
        {

        }

        public override int GetCost() => shaurma.GetCost();
    }
}
