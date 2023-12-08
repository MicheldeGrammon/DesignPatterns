using Decorator.Shaurms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class BeefShaurma : DecoratorShaurma
    {
        public BeefShaurma(Shaurma shaurma) : base($"{shaurma.Name} c говядиной", shaurma)
        {

        }

        public override int GetCost() => shaurma.GetCost() + 25;
    }
}
