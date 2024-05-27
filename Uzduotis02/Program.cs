namespace Uzduotis02
{
    // KELIONIŲ AGENTŪRA
    // Sukurkite sąrašą, kuriame būtų laikomos įvairios kelionės(tiek Atostogos, tiek Komandiruote, tiek EkstremaliKelione).
    // Naudodami ciklą iteruokite per šį sąrašą ir užsakykite įvairias keliones, naudodami skirtingas kryptis ir dienų skaičių.
    // Jei kelionės užsakymas sėkmingas, išveskite pranešimą apie sėkmingą užsakymą ir galutinę kelionės kainą.
    // Papildomi reikalavimai:
    // Kiekviena kelionė turi turėti pradinę bazinę kainą (pvz., 100 € už dieną).
    // Pridėkite galimybę rodyti visas užsakytas keliones ir jų detales.

    internal class Program
    {
        private static TravelAgency travelAgency = new();

        public static void Main(string[] args)
        {
            // Create 30 random trips
            for (int i = 0; i < 30; i++)
            {
                travelAgency.AddTrip(travelAgency.OrderTrip(travelAgency.RandomTripType(out double priceModifier),
                    travelAgency.RandomDirection(out double basePrice),travelAgency.RandomDaysAmount(), basePrice, priceModifier));
            }
            Console.WriteLine();

            // "Pridėkite galimybę rodyti visas užsakytas keliones ir jų detales."
            if (travelAgency.YesOrNo())
                travelAgency.DisplayAllTrips();
        }
    }
}