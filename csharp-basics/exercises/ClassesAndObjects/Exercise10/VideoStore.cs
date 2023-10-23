namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void CheckOut(string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Title == title)
                {
                    _inventory[i].BeingCheckedOut();
                    break;
                }
            }
        }
        
        public void ReturnedVideo(string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Title == title)
                {
                    _inventory[i].BeingReturned();
                    break;
                }
            }
        }

        public void RaceivedRating(string title, double rating)
        {
            {
                for (int i = 0; i < _inventory.Count; i++)
                {
                    if (_inventory[i].Title == title)
                    {
                        _inventory[i].RecievedRating(rating);
                        break;
                    }
                }
            }
        }
        public void ListInventory()
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                    var video = _inventory[i];
                    Console.WriteLine(video);
            }
        }       
    }
}