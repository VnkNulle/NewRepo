using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> inventory = new List<Video>();

        public void AddVideo(string title)
        {
            inventory.Add(new Video { Title = title });
        }

        public Video GetVideo(string title)
        {
            return inventory.Find(video => video.Title == title);
        }

        public void RentVideo(string title)
        {
            Video video = GetVideo(title);
            if (video != null && !video.IsCheckedOut)
                video.CheckOut();
        }

        public void ReturnVideo(string title)
        {
            Video video = GetVideo(title);
            if (video != null && video.IsCheckedOut)
                video.Return();
        }

        public void RateVideo(string title, int rating)
        {
            Video video = GetVideo(title);
            if (video != null)
                video.ReceiveRating(rating);
        }

        public void ListInventory()
        {
            foreach (Video video in inventory)
            {
                Console.WriteLine($"Title: {video.Title}, Average Rating: {video.AverageRating}, Checked Out: {video.IsCheckedOut}");
            }
        }
    }
}
