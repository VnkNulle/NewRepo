namespace AdApp
{
    public class Poster : Advert
    {
        private int _dimensions;
        private int _numCopies;
        private int _costPerCopy;

        public Poster(int fee, int dimensions, int numCopies, int costPerCopy) : base(fee)
        {
            _dimensions = dimensions;
            _numCopies = numCopies;
            _costPerCopy = costPerCopy;
        }

        public new int Cost()
        {
            int baseCost = base.Cost();
            int totalCost = baseCost + (_numCopies * _costPerCopy);
            return totalCost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPoster: Dimensions={_dimensions}, Copies={_numCopies}, Cost per Copy={_costPerCopy}";
        }
    }
}
