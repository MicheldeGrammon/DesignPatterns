using Builder.Pilafs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    internal class Oshpaz
    {
        public Pilaf CreatePlaif(PilafBuilder pilafBuilder)
        {
            pilafBuilder.CreatePlaif();
            pilafBuilder.SetRice();
            pilafBuilder.SetMeat();
            pilafBuilder.SetCarrot();

            return pilafBuilder.Pilaf;
        }
    }
}
