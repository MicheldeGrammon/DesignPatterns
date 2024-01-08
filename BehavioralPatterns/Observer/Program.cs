namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var device = new ControlledDevice();
            var zabbix = new Zabbix(device);

            device.ImitationWork();
        }
    }
}
