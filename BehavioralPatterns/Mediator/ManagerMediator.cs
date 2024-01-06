
namespace Mediator
{
    class ManagerMediator : Mediator
    {
        public override void Send(string msg, Colleague colleague)
        {
            if (Colleagues.Contains(colleague))
            {
                colleague.Notify(msg);
            }
            else
            {
                Console.WriteLine($"Error: пользователь не зарегестрирован");
            }
        }
    }
}
