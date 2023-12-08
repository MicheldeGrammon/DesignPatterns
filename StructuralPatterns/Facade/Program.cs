namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var architect = new Architect();
            var brigade = new Brigade();
            var materials = new Materials();
            var facade = new FacadeBuilder(architect, materials, brigade);

            facade.BuildHouse();
        }
    }
}