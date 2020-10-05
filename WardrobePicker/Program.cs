using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = { "red", "blue", "white", "green", "pink" };
            string[] patterns = { "flowery", "striped", "polka dot", "circles", "checkered"};

            /*The program asks if the user needs help with picking an outfit
             If the user answers no, the console displays "Farewell"
            If th users confirms, the program displays a random combination of
            pattern, color and clothing item
            "Today you should wear...
             */
      

            Random rnd = new Random();

            Console.WriteLine("Would you like some fashion advice?");
            string userInput = Console.ReadLine();

            if(userInput == "no")
            {
                Console.WriteLine("Farewell!");
            } else
            {
                Console.WriteLine($"Today, you should wear " +
                    $"{colors[rnd.Next(0, colors.Length)]} " +
                    $"{patterns[rnd.Next(0, patterns.Length)]} " + 
                    $"{wardrobe[rnd.Next(0, wardrobe.Length)]}");
            }

        }
    }
}
