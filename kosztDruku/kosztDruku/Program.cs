using System;

namespace PrintCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the amount of books you would like to print?");
            int booksCount;
            while (!int.TryParse(Console.ReadLine(), out booksCount))
            {
                Console.WriteLine("\rError\nPlease enter valid value:");
            }
            var bookCost = CalculateBookCost(booksCount);
            var totalCost = bookCost * booksCount;
            Console.WriteLine("Total cost: " + totalCost);
            Console.Read();
        }

        private static int CalculateBookCost(int booksCount)
        {
            if (booksCount > 1000)
                return 10;
            else if (booksCount > 500)
                return 12;
            else
                return 15;
        }
    }
}
