using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; }

        public double AverageRating => _rating.Any() ? _rating.Average() : 0;

        private List<double> _rating;

        public Video(string title)
        {
            Title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            IsAvailable = false;
        }

        public void BeingReturned()
        {
            IsAvailable = true;
        }

        public void RecievedRating(double rating)
        {
            _rating.Add(rating);
        }

        public override string ToString()
        {
            GetType().ToString();
            return $"{Title}, rating {AverageRating}, IsAvailable {IsAvailable}";                  
        }
    }
}
