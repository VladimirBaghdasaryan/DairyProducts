namespace Dairyproducts
{
    internal class Yogurt : CottageCheese
    {
        public string Description { get; set; }

        public Yogurt(string country, string brand, double oiliness, double weight, decimal price, bool isSugar, string description) : base(country, brand, oiliness, weight, price, isSugar)
        {
            Description = description;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Description:" + Description);

        }
    }
}
