using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class JuniorAdapter : IWorker
    {
        private readonly Junior _junior = new Junior();

        public void RunWork()
        {
            _junior.RunProgramming();
        }
    }
}
