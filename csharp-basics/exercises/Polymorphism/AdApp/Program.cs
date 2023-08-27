using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500));
            c.AddAdvert(new NewspaperAd(300));
            c.AddAdvert(new TVAd(1500));
            c.AddAdvert(new Poster(200, 60, 1000, 1));
            Console.WriteLine(c);
        }
    }
}
