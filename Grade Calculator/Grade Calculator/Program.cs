using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            string input = Console.ReadLine();
            int grade;

            // Validate the input
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                // Determine the letter grade
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the letter grade
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            }
        }
    }
}
