namespace Uzduotis02
{
    // Sukurkite interface'ą pavadinimu IKelionesUzsakymas, kuriame būtų aprašyti du metodai:
    // void UzsakytiKelione(string kryptis, int dienuSk): metodas, kuris priima kelionės kryptį ir dienų skaičių, bei vykdo kelionės užsakymą.
    // double GautiKelionesKaina(): metodas, kuris grąžina kelionės kainą.
    internal interface ITripOrder
    {
        void OrderTrip(string direction, int daysAmount);
        double GetTripCost();
    }
}
