namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _numDays;
        private int _standardCost;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int numDays, int standardCost, bool isPrimeLocation) : base(fee)
        {
            _numDays = numDays;
            _standardCost = standardCost;
            _isPrimeLocation = isPrimeLocation;
        }

        public new int Cost()
        {
            int baseCost = base.Cost();
            int totalCost = baseCost + (_numDays * _standardCost);

            if (_isPrimeLocation)
            {
                totalCost += (int)(0.5 * _standardCost);
            }

            return totalCost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nHoarding: Days={_numDays}, Standard Cost={_standardCost}, Prime Location={_isPrimeLocation}";
        }
    }
}
