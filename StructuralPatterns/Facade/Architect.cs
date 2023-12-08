using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Architect
    {
        public void GetDesignPlan() => CreateDesignPlan();

        private void CreateDesignPlan() => Console.WriteLine("Создан план постройки");
    }
}
