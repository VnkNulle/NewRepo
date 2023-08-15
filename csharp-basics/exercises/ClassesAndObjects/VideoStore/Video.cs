using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public string Title { get; set; }
        public bool IsCheckedOut { get; set; }
        public List<int> Ratings { get; } = new List<int>();

        public double AverageRating
        {
            get
            {
                if (Ratings.Count == 0)
                    return 0;
                return Ratings.Sum() / (double)Ratings.Count;
            }
        }

        public void CheckOut()
        {
            IsCheckedOut = true;
        }

        public void Return()
        {
            IsCheckedOut = false;
        }

        public void ReceiveRating(int rating)
        {
            Ratings.Add(rating);
        }
    }
}
