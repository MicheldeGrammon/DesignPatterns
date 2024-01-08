using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface IObservable
    {
        public void Register(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
    }
}
