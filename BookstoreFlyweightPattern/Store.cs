using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreFlyweightPattern
{
    internal class Store
    {
        private List<Book> books = new List<Book>();

        public void StoreBook(string name, double price, string type, string distributor)
        {
            BookType bookType = BookFactory.GetBookType(type, distributor);
            books.Add(new Book(name, price, bookType));
        }
    }
}
