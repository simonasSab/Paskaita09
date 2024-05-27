namespace Uzduotis02
{
    // Paveldėkite klasę Kelione ir sukurkite kelias klases: Atostogos, Komandiruote, ir EkstremaliKelione. Visos šios klasės turi implementuoti IKelionesUzsakymas interface'ą.
    // Klasėje Komandiruote įgyvendinkite šiuos metodus:
    // UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių.
    // Bazinė kaina turi būti padauginta iš dienų skaičiaus, tačiau komandiruotės atveju gali būti taikoma nuolaida (pvz., 20%).
    // GautiKelionesKaina() : grąžina galutinę kelionės kainą, įskaitant nuolaidą.

    internal class Secondment : Trip, ITripOrder
    {
        protected double Discount { get; set; } // Value from 0 to 1.00, where 0.00 is 0% discount, 1.00 is 100% discount

        public Secondment(string direction, int daysAmount, double basePrice, double discount) : base(direction, daysAmount, basePrice)
        {
            Direction = direction;
            DaysAmount = daysAmount;
            BasePrice = basePrice;
            Discount = Clamp(discount, 0, 1);
        }
        public double GetTripCost()
        {
            double tripCost = BasePrice * DaysAmount;
            return Math.Round(tripCost - tripCost * Discount, 2);
        }
        public override string ToString()
        {
            return $"Secondment: {Direction} for {DaysAmount} days ({BasePrice} Eur/day, Discount: -{(int)(Discount * 100)}%, Total: {GetTripCost()} Eur)";
        }
    }
}
