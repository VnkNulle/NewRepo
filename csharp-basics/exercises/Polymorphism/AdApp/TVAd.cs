namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;
        private bool _isPeakTime;

        public TVAd(int fee, int seconds, bool isPeakTime) : base(fee)
        {
            _seconds = seconds;
            _isPeakTime = isPeakTime;
        }

        public new int Cost()
        {
            int baseCost = base.Cost();
            int standardCost = _isPeakTime ? (2 * baseCost) : baseCost;
            int totalCost = standardCost * _seconds;

            return totalCost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTV Ad: Seconds={_seconds}, Peak Time={_isPeakTime}";
        }
    }
}
