using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreFlyweightPattern
{
    internal class BookType
    {
        public BookType(string type, string distributor)
        {
            Type = type;
            Distributor = distributor;
        }

        public string Type { get; set; }
        public string Distributor { get; set; }


    }
}
