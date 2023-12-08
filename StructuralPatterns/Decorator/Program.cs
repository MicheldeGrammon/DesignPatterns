using Decorator.Decorators;
using Decorator.Shaurms;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shaurma shaurma1 = new MiniShaurma();
            shaurma1 = new ChickenShaurma(shaurma1);
            Console.WriteLine($"Название: {shaurma1.Name}");
            Console.WriteLine($"Цена: {shaurma1.GetCost()}\n");

            Shaurma shaurma2 = new MiniShaurma();
            shaurma2 = new BeefShaurma(shaurma2);
            Console.WriteLine($"Название: {shaurma2.Name}");
            Console.WriteLine($"Цена: {shaurma2.GetCost()}\n");

            Shaurma shaurma3 = new StandartShaurma();
            shaurma3 = new ChickenShaurma(shaurma3);
            Console.WriteLine($"Название: {shaurma3.Name}");
            Console.WriteLine($"Цена: {shaurma3.GetCost()}\n");

            Shaurma shaurma4 = new BigShaurma();
            shaurma4 = new BeefShaurma(shaurma4);
            Console.WriteLine($"Название: {shaurma4.Name}");
            Console.WriteLine($"Цена: {shaurma4.GetCost()}\n");
        }
    }
}