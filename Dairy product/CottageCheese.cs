namespace Dairyproducts
{
    internal class CottageCheese : Milk
    {
        public bool IsSugar { get; set; }

        public CottageCheese(string country, string brand, double oiliness, double weight, decimal price, bool isSugar) : base(country, brand, oiliness, weight, price)
        {
            IsSugar = isSugar;
        }

        public CottageCheese(string country, string brand, double oiliness, double weight, decimal price) : base(country, brand, oiliness, weight, price)
        {
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("IsSugar:" + IsSugar);

        }
    }
}
