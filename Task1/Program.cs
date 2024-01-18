using System.Text.RegularExpressions;

namespace Task1
{
    internal class Program
    {
        static string GetCellColor(string cell)
        {
            string pattern = "^[A-Ha-h][1-8]$";

            if (!Regex.IsMatch(cell, pattern))
            {
                return "Invalid pattern.";
            }

            return (cell[0] + cell[1]) % 2 == 1 ? "White" : "Black";
        }

        static void Main(string[] args)
        {
            string userInput, result;
            while (true)
            {
                Console.Write("\nEnter the cell ('q' to exit): ");
                userInput = Console.ReadLine();
                if (userInput.Equals("q")) break;
                result = GetCellColor(cell: userInput);
                Console.WriteLine(result);
            }
        }
    }
}
