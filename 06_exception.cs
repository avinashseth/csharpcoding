using System; // Import the Base Class Library

namespace day2 // Organize your code
{
    class Program // Everything lives in a Class
    {

        static void Main(string[] args) // The Entry Point
        {

            try
            {
                Console.Write("Enter a number to divide 100 by: ");
                int input = int.Parse(Console.ReadLine());

                int result = 100 / input;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number, not text.");
            }
            finally
            {
                Console.WriteLine("Thank you for using the calculator.");
            }


        }
    }
}
