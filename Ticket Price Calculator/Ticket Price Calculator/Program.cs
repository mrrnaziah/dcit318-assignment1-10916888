using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants for ticket prices
            const decimal regularPrice = 10.00m;
            const decimal discountedPrice = 7.00m;

            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Validate the input
            if (int.TryParse(input, out age) && age >= 0)
            {
                // Determine the ticket price based on the age
                decimal ticketPrice;
                if (age <= 12 || age >= 65)
                {
                    ticketPrice = discountedPrice;
                }
                else
                {
                    ticketPrice = regularPrice;
                }

                // Display the ticket price
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
