using System;
using System.Dynamic;

namespace UserAgainsZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user to enter the names of
             * five items from the user's bag.
             * The program displays a random pick from the user's bag
             * to fight off zombies with.
             * "In case of zombie apocalypse you will have to 
             * fight zombies with {random item from the bag}"
             */
            string[] userBag = new string[5];
            int i = 0;
            while(i < userBag.Length)
            {
                Console.WriteLine("What's there in your bag?");
                userBag[i] = Console.ReadLine();
                i++;
            }

            Random rnd = new Random();
            Console.WriteLine($"In case of zombie apocalypse you will have to" +
                $"fight zombies off with a {userBag[rnd.Next(0, userBag.Length)]}");
        }
    }
}
