namespace Dairyproducts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Milk milk = new Milk("Italy", "Lactel", 4, 1, 500);
            milk.DisplayInfo();
            Console.WriteLine(new string('-', 40));
            CottageCheese cottageCheese = new CottageCheese("Armenia", "Marianna", 10, 1, 750, true);
            cottageCheese.DisplayInfo();
            Console.WriteLine(new string('-', 40));
            Yogurt yogurt = new Yogurt("Armenia", "BioKat", 2.5, 0.5, 320, true, "Elaki hamov");
            yogurt.DisplayInfo();
        }
    }
}