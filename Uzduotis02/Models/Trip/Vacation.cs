namespace Uzduotis02
{
    // Paveldėkite klasę Kelione ir sukurkite kelias klases: Atostogos, Komandiruote, ir EkstremaliKelione. Visos šios klasės turi implementuoti IKelionesUzsakymas interface'ą.
    // Klasėje Atostogos įgyvendinkite šiuos metodus:
    // UzsakytiKelione(string kryptis, int dienuSk) : nustato kelionės kryptį ir dienų skaičių.
    // Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už atostogas (pvz., 50 €).
    // GautiKelionesKaina() : grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.

    internal class Vacation : Trip, ITripOrder
    {
        public Vacation(string direction, int daysAmount, double basePrice) : base(direction, daysAmount, basePrice)
        {
            Direction = direction;
            DaysAmount = daysAmount;
            BasePrice = basePrice;
        }
        public double GetTripCost()
        {
            double tripCost = Math.Round((BasePrice * DaysAmount), 2);
            return tripCost;
        }
        public override string ToString()
        {
            return $"Vacation: {Direction} for {DaysAmount} days ({BasePrice} Eur/day, Total: {GetTripCost()} Eur)";
        }
    }
}
