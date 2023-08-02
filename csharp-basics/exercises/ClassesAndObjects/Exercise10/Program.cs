using System;

namespace VideoStore
{

    class Program
    {
        public static VideoStore _store;
        public static void Main(string[] args)       
        {
            _store = new VideoStore(); 
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());            

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        RecieveRating();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void RecieveRating()
        {
            var title = "spider man";
            _store.ReturnedVideo(title);
        }

        private static void ListInventory()
        {

        }

        private static void FillVideoStore()
        {
            
        }

        private static void RentVideo()
        {
            var title = "spider man";
            _store.CheckOut(title);
        }

        private static void ReturnVideo()
        {
            var title = "spider man";
            _store.ReturnedVideo(title);
        }
    }
}