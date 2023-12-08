using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class FacadeBuilder
    {
        private readonly Architect _architect;
        private readonly Materials _materials;
        private readonly Brigade _brigade;
        public FacadeBuilder(Architect architect, Materials materials, Brigade brigade)
        {
            _architect = architect;
            _materials = materials;
            _brigade = brigade;
        }

        public void BuildHouse()
        {
            _architect.GetDesignPlan();
            _materials.GetMaterials();
            _brigade.Preparation();
            _brigade.BuildHouse();
        }
    }
}
