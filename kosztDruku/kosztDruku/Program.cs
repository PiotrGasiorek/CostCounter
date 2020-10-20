using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosztDruku
{
    class Program
    {
        static void Main(string[] args)
        {
            int BooksCount, BookCost, TotalCost;
            Console.WriteLine("What is the amount of books you would like to print?");
            while ( !int.TryParse(Console.ReadLine(), out BooksCount) )
            {
                Console.WriteLine("Error");
                Console.WriteLine("Please enter valid value:");
            }

            /*Calculate cost for single book*/
            if( BooksCount > 1000 )
            {
                BookCost = 10;
            } 
            else if ( BooksCount > 500)
            {
                BookCost = 12;
            }
            else
            {
                BookCost = 15;
            }

            TotalCost = BookCost * BooksCount;
            Console.WriteLine("Total cost: " + TotalCost);

            Console.Read();
        }
    }
}
