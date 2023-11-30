using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Worker
    {

        private static Worker instance;
        public string Name { get; private set; }
        public DateTime TimeInstance { get; private set; }

        private Worker(string name)
        {
            Name = name;
            TimeInstance = DateTime.Now;
        }

        public static Worker GetInstance(string name)
        {
            if (instance == null)
                instance = new Worker(name);

            return instance;
        }
    }
}