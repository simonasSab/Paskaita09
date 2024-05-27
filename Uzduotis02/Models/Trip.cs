namespace Uzduotis02
{
    // Sukurkite tėvinę klasę Kelione, kuri turi šiuos laukus ir metodus:
    // Laukai: public string Kryptis, protected int DienuSkaicius, protected double BazinesKainos.
    // Metodai: public double GautiBazinesKainos(): grąžina bazinę kelionės kainą.

    internal class Trip
    {
        public string Direction { get; set; }
        protected int DaysAmount { get; set; }
        protected double BasePrice { get; set; }

        public Trip(string direction, int daysAmount, double basePrice)
        {
            Direction = direction;
            DaysAmount = daysAmount;
            BasePrice = basePrice;
        }

        public double GetBasePrice()
        {
            return BasePrice;
        }

        protected static double Clamp(double value, double min, double max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        protected static double Clamp(double value, double min)
        {
            return (value < min) ? min : value;
        }

        public void OrderTrip(string direction, int daysAmount)
        {
            Direction = direction;
            DaysAmount = daysAmount;
        }
    }
}
