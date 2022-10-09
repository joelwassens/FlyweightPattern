using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreFlyweightPattern
{
    internal class BookFactory
    {
        private static Dictionary<string, BookType> _bookTypes = new Dictionary<string, BookType>();

        public static BookType GetBookType(string type, string distributor)
        {
            string key = type + distributor;
            if (_bookTypes.ContainsKey(key) == false)
            {
                _bookTypes.Add(key, new BookType(type, distributor));
            }
            return _bookTypes[key];
        }
    }
}
