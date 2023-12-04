namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuniorAdapter worker1 = new JuniorAdapter();
            StreetCleanerAdapter worker2 = new StreetCleanerAdapter();

            var employees = new List<IWorker>();
            employees.Add(worker1);
            employees.Add(worker2);

            foreach (var employee in employees) 
            { 
                employee.RunWork();
            }
        }
    }
}