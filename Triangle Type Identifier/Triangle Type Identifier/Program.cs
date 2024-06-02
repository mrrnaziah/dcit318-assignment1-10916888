using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the sides
            Console.Write("Enter the length of side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine();

            // Variables to store the side lengths
            double side1, side2, side3;

            // Validate the input
            if (double.TryParse(input1, out side1) && side1 > 0 &&
                double.TryParse(input2, out side2) && side2 > 0 &&
                double.TryParse(input3, out side3) && side3 > 0)
            {
                // Determine the type of triangle
                string triangleType;
                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }

                // Display the type of triangle
                Console.WriteLine($"The triangle is {triangleType}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numerical values for the sides.");
            }
        }
    }
}
