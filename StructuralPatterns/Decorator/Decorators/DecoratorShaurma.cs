using Decorator.Shaurms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal abstract class DecoratorShaurma : Shaurma
    {
        protected Shaurma shaurma;
        protected DecoratorShaurma(string name, Shaurma shaurma) : base(name)
        {
            this.shaurma = shaurma;
        }
    }
}
