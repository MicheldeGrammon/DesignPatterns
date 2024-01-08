using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Zabbix : IObserver
    {
        IObservable controlledDevice;

        public Zabbix(IObservable observable)
        {
            controlledDevice = observable;
            controlledDevice.Register(this);
        }

        public void Update(object ob)
        {
            var metrics = (Metrics)ob;

            if (metrics.Temperature > 80)
                Console.WriteLine("Критическая температура, высокая опасность");
            else
                Console.WriteLine("Температура в норме");

            if (metrics.Availability)
                Console.WriteLine("Доступ к устройству есть");
            else
                Console.WriteLine("Не удалось получить доступ к устройству");
        }
    }
}
