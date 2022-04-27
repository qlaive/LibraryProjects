using System;

namespace LibraryProjects
{
    internal class Program
    {
        class Library
        {
            public void checkOutBook()
            {
                Console.Write("Enter customers name: ");
                Console.Read();
                Console.WriteLine("Enter book name: ");
                Console.Read();

            }
            public void checkInBook()
            {

            }
        }

        class Books
        {
            public string author;
            public string ISBN;
            public string title;
            public int numberOfPages;

        }

        class Customers
        {
            public string name;
            

        }
        static void Main(string[] args)
        {
            Books theFellowship = new Books();
            theFellowship.author = "J.R.R. Tolkien";
            theFellowship.title = "Lord Of The Rings: The Fellowship Of The Ring";
            theFellowship.numberOfPages = 423;

            Customers customer1 = new Customers();
            customer1.name = "Timothy Fee";

            Customers customer2 = new Customers();
            customer2.name = "Maribel Cerca";

        }
    }
}
