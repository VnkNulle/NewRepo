namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _columnCmCost;

        public NewspaperAd(int fee, int columnCmCost) : base(fee)
        {
            _columnCmCost = columnCmCost;
        }

        public new int Cost()
        {
            int baseCost = base.Cost();
            int totalCost = baseCost + _columnCmCost;

            return totalCost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNewspaper Ad: Column Cm Cost={_columnCmCost}";
        }
    }
}
