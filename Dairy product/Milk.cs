namespace Dairyproducts
{
    internal class Milk
    {
        public string Country { get; set; }
        public string Brand { get; set; }
        public double Oiliness { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }

        public Milk(string country, string brand, double oiliness, double weight, decimal price)
        {
            Country = country;
            Brand = brand;
            Oiliness = oiliness;
            Weight = weight;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Country:" + Country);
            Console.WriteLine("Brand:" + Brand);
            Console.WriteLine("Oiliness:" + Oiliness + "%");
            Console.WriteLine("Weight:" + Weight + " Liter");
            Console.WriteLine("Price:" + Price);
        }
    }
}
