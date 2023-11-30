using Builder.Pilafs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class PilafBuilder
    {
        public Pilaf Pilaf { get; private set; }
        public void CreatePlaif()
        {
            Pilaf = new Pilaf();
        }
        public abstract void SetMeat();
        public abstract void SetCarrot();
        public abstract void SetRice();
    }
}
