namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oshpaz = new Oshpaz(); //Повар

            var samarkandBuilder = new SamarkandBuilder(); // в данном случае билдер представляет собой репецпт
            var sofiOshiBuilder = new SofiOshiBuilder();

            var pilaf1 = oshpaz.CreatePlaif(samarkandBuilder).GetPilaf(); //один повар может готовить плов по разным рецептам
            var pilaf2 = oshpaz.CreatePlaif(sofiOshiBuilder).GetPilaf();

            Console.WriteLine($"pilaf1: {pilaf1}");
            Console.WriteLine($"pilaf2: {pilaf2}");
        }
    }
}