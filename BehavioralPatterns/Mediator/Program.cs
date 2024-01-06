
namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator manager = new ManagerMediator();

            Colleague customer = new CustomerColleague(manager);
            Colleague programmer = new ProgrammerColleague(manager);
            Colleague tester = new TesterColleague(manager);

            manager.Register(customer);
            manager.Register(programmer);
            manager.Register(tester);

            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");
        }
    }
}
