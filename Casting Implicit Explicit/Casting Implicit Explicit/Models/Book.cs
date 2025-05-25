using Casting_Implicit_Explicit.Exceptions;
using System;

namespace Casting_Implicit_Explicit.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, double price, int count, string authorName, int pageCount)
        {
            Name = name;
            Price = price;
            Count = count;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Author: {AuthorName}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Price: {Price} AZN");
            Console.WriteLine($"Stock Count: {Count}");
            Console.WriteLine($"Total Income: {TotalIncome} AZN");
        }

        public override void Sell()
        {
            if (Count == 0)
                throw new ProductCountIsZeroException($"Kitab stokda yoxdur: {Name}");

            Count--;
            TotalIncome += Price;
        }
    }
}
