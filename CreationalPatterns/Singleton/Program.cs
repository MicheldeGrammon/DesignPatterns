namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var worker1 = Worker.GetInstance("worker1");
            Console.WriteLine($"Worker1\nName: {worker1.Name}, Time: {worker1.TimeInstance}");

            Thread.Sleep( 2000 );
            Console.WriteLine();

            var worker2 = Worker.GetInstance("worker2");
            Console.WriteLine($"Worker2\nName: {worker2.Name}, Time: {worker2.TimeInstance}");
        }
    }
}