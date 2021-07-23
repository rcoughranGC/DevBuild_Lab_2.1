using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method asking whether to continue
            static bool UserContinue()
            {
                Console.WriteLine("\nContinue with another room? (y/n)");
                string userChoice = Console.ReadLine();

                if (userChoice.ToLower().StartsWith("y"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            do
            {
                // Get the dimensions from the user

                Console.Write("Please enter the room length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Please enter the room length: ");
                double width = double.Parse(Console.ReadLine());

                // Try to get the height.
                
                Console.Write("Please enter the room height: (If unknown leave blank) ");
                string tempHeight = Console.ReadLine();

                // See if user entered a valid height. If not valid, set to 10, consider volume to be an estimate.

                bool isEstimatedHeight = false;
                bool validHeight = Double.TryParse(tempHeight, out double height);
                if (!validHeight)
                {
                   height = 10;
                   isEstimatedHeight = true;
                }
                
                // Calculate and display dimensions

                double roomArea = length * width;
                double roomPerimeter = (length * 2) + (width * 2);
                double roomVolume = length * width * height;

                Console.WriteLine($"Area: {roomArea}");
                Console.WriteLine($"Perimeter: {roomPerimeter}");
                if (isEstimatedHeight)
                {
                    Console.WriteLine($"Estimated Volume: {roomVolume}");
                }
                else
                {
                    Console.WriteLine($"Volume: {roomVolume}");
                }

                // Display size 

                if (roomArea <= 250)
                {
                    Console.WriteLine("This is a small-sized room.");
                }
                else if (roomArea < 650)
                {
                    Console.WriteLine("This is a medium-sized room.");
                }
                else
                {
                    Console.WriteLine("This is a large-sized room.");
                }
            } 
            while (UserContinue());

        }
    }
}
