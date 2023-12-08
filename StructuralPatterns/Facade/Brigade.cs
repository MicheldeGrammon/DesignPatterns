using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Brigade
    {
        public void Preparation() => Console.WriteLine("Подготовка к работе, (предварительные работы)");
        public void BuildHouse() => Console.WriteLine("Постройка дома");
    }
}
