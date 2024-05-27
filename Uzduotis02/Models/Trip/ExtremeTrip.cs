namespace Uzduotis02
{
    // Paveldėkite klasę Kelione ir sukurkite kelias klases: Atostogos, Komandiruote, ir EkstremaliKelione. Visos šios klasės turi implementuoti IKelionesUzsakymas interface'ą.
    // Klasėje EkstremaliKelione įgyvendinkite šiuos metodus:
    // UzsakytiKelione(string kryptis, int dienuSk) : nustato kelionės kryptį ir dienų skaičių.
    // Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už ekstremalias veiklas (pvz., 100 €).
    // GautiKelionesKaina() : grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.

    internal class ExtremeTrip : Trip, ITripOrder
    {
        protected double ExtremeServices { get; set; }

        public ExtremeTrip(string direction, int daysAmount, double basePrice, double extraServices) : base(direction, daysAmount, basePrice)
        {
            Direction = direction;
            DaysAmount = daysAmount;
            BasePrice = basePrice;
            ExtremeServices = Clamp(extraServices, 0);
        }

        public double GetTripCost()
        {
            double tripCost = BasePrice * DaysAmount;
            return Math.Round(tripCost + ExtremeServices, 2);
        }

        public override string ToString()
        {
            return $"Extreme Trip: {Direction} for {DaysAmount} days ({BasePrice} Eur/day, Extras: {ExtremeServices} Eur, Total: {GetTripCost()} Eur)";
        }
    }
}
