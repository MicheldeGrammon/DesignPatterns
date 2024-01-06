
namespace Mediator
{
    abstract class Mediator
    {
        protected List<Colleague> Colleagues = new List<Colleague>();
        public abstract void Send(string msg, Colleague colleague);

        public void Register(Colleague colleague)
        {
            if (!Colleagues.Contains(colleague))
                Colleagues.Add(colleague);
        }

    }
}
