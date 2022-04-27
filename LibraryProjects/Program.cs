using System;
using System.Collections.Generic;


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
            public static int countBooks<T>(List<T>books)
            //Had to make the method "static" instead of void to allow it to be called in the main method.
            {
                
                return books.Count;
                //Returning the value instead of console.writeline to allow it to be called.
            }
        }

        class Book
        {
            public string author;
            public string ISBN;
            public string title;
            public int numberOfPages;
        }

        class Customers
        {
            public string Name { get; set; }


        }
            static void Main(string[] args)
            {
                

                Book theFellowship = new Book();
                theFellowship.author = "J.R.R. Tolkien";
                theFellowship.title = "Lord Of The Rings: The Fellowship Of The Ring";
                theFellowship.numberOfPages = 423;

                Book theTwoTowers = new Book();
                theTwoTowers.author = "J.R.R. Tolkien";
                theTwoTowers.title = "Lord Of The Rings: The Two Towers";
                theTwoTowers.numberOfPages = 352;


                Book returnOfTheKing = new Book();
                returnOfTheKing.author = "J.R.R. Tolkien";
                returnOfTheKing.title = "Lord Of The Rings: Return Of The King";
                returnOfTheKing.numberOfPages = 416;


                List<Book> books = new List<Book>(3);
                books.Add(theFellowship);
                books.Add(theTwoTowers);
                books.Add(returnOfTheKing);

           


                Customers customer1 = new Customers();
                customer1.Name = "Timothy";

                Customers customer2 = new Customers();
                customer1.Name = "Maribel";

                List<Customers> customers = new List<Customers>(2);
                customers.Add(customer1);
                customers.Add(customer2);


                Console.WriteLine(Library.countBooks(books));

            }
        }

    }
