namespace Uzduotis02
{
    // Sukurkite klasę KelioniuAgentura, kuri turi šiuos laukus ir metodus:
    // Laukai: private List<Kelione> keliones: sąrašas su visomis kelionėmis.
    // Metodai:
    // public void PridetiKelione(Kelione kelione): prideda kelionę į sąrašą.
    // public void UzsakytiKelione(string kelionėsTipas, string kryptis, int dienuSk): sukuria ir užsako kelionę pagal tipą, kryptį ir dienų skaičių.
    // public void RodytiVisasKeliones(): išveda visas užsakytas keliones su jų kainomis.

    internal class TravelAgency
    {
        private List<Trip> Trips { get; set; }

        public TravelAgency()
        {
            Trips = new();
        }

        public void AddTrip(Trip? trip)
        {
            if (trip != null)
            {
                Trips.Add(trip);
                Console.WriteLine($"Added trip successfully: {trip.ToString()}");
            }
            else
            {
                Console.WriteLine("Trip not added\n");
            }
        }

        public Trip? OrderTrip(string tripType, string direction, int daysAmount, double basePrice, double priceModifier)
        {
            if (direction == null)
            {
                Console.WriteLine("Incorrect direction\n");
                return null;
            }

            tripType = (tripType.ToLower()).Trim();
            
            switch (tripType)
            {
                case "vacation":
                    Vacation vacation = new(direction, daysAmount, basePrice);
                    return vacation;
                case "extremetrip":
                    ExtremeTrip extremeTrip = new(direction, daysAmount, basePrice, priceModifier);
                    return extremeTrip;
                case "secondment":
                    Secondment secondment = new(direction, daysAmount, basePrice, priceModifier);
                    return secondment;
                default:
                    Console.WriteLine("Incorrect trip type");
                    return null;
            }
        }

        public void DisplayAllTrips()
        {
            if (Trips.Count > 0)
            {
                Console.WriteLine("All currently planned trips:\n");

                foreach (Trip trip in Trips)
                {
                    Console.WriteLine($"{trip.ToString()}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The trip list is empty.\n");
            }
        }

        /* __________________________ Additional methods to determine parameters __________________________ */

        public string RandomTripType(out double priceModifier)
        {
            Random random = new();
            int option = random.Next(3);
            switch (option)
            {
                case 0:
                    priceModifier = 0;
                    return "vacation";
                case 1:
                    priceModifier = random.Next(30, 301);
                    return "extremetrip";
                case 2:
                    priceModifier = Math.Round(random.NextDouble(), 2);
                    return "secondment";
                default:
                    priceModifier = 0;
                    return "";
            }
        }

        public string RandomDirection(out double basePrice)
        {
            Random random = new();
            int price = random.Next(1, 11) * 50;
            string? direction = Enum.GetName(typeof(Direction), price);
            basePrice = price;

            if (direction != null)
                return direction;
            else
                return "";
        }

        public int RandomDaysAmount()
        {
            Random random = new();
            return random.Next(2, 31);
        }

        public bool YesOrNo()
        {
            string? response = "";
            do
            {
                Console.WriteLine("\nWould you like to see a list of all trips (yes/no)?");
                response = Console.ReadLine();
                if (response != null)
                    response = response.ToLower();
            }
            while (response == null || (response != "yes" && response != "no"));

            if (response == "yes")
                return true;
            else
                return false;
        }
    }
}
