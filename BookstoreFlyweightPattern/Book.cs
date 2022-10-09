using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreFlyweightPattern
{
    internal class Book
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private BookType Type { get; set; }
        public Book(string name, double price, BookType booktype)
        {
            Name = name;
            Price = price; 
            Type = booktype;
        }

        public Book(string name, double price, string type, string distributor)
        {
            Name = name;
            Price = price;
            Type = new BookType(type, distributor);
        }
        

    }
}
