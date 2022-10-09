using BookstoreFlyweightPattern;

int BooksToInsert = 10000000;
Store store = new Store();
List<Book> books = new List<Book>();
for(int i = 1; i <= BooksToInsert; i++)
{
    /*store.StoreBook("Ufo's en aliens", 19.99, "Sciencefiction", "DeBoom");
    store.StoreBook("Friday the 14th", 24.99, "Horror", "DeStruik");
    store.StoreBook("Dikke actie", 29.99, "Action", "DeTak");
    store.StoreBook("Lord of the watches", 15.99, "Fantasy", "HetBlaadje");*/

    books.Add(new Book("Ufo's en aliens", 19.99, "Sciencefiction", "DeBoom"));
    books.Add(new Book("Friday the 14th", 24.99, "Horror", "DeStruik"));
    books.Add(new Book("Dikke actie", 29.99, "Action", "DeTak"));
    books.Add(new Book("Lord of the watches", 15.99, "Fantasy", "HetBlaadje"));
}
double g = GC.GetTotalMemory(false);
Console.WriteLine(Math.Round(g/1000000000*100)/100 + " GB");
Console.ReadLine();

