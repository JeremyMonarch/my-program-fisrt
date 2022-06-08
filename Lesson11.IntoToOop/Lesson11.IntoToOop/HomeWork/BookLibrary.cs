using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.IntoToOop.HomeWork
{
    public class BookLibrary
    {
        public int numberOfRack;
        public Rack[] Racks;

        public BookLibrary(int countofrack, int countofshelf, int countofbook)
        {
            numberOfRack = countofrack;
            Racks = new Rack[numberOfRack];

            for (int i = 0; i < Racks.Length; i++)
            {
                Racks[i] = new Rack(countofshelf, countofbook, i + 1);
            }
        }

        public void Print()
        {
            Console.WriteLine("библиотека:");
            for (int i = 0; i < Racks.Length; i++)
            {
                if (Racks[i] != null)
                {
                    Racks[i].Print();
                }
            }
        }

        public void AddBook(int RackNo, int ShelfNo, Book Ubook)
        {
            if (Racks[RackNo] != null)
            {
                if (Racks[RackNo].BooksShelfs[ShelfNo] != null)
                {
                    for (int i = 0;  i < Racks[RackNo].BooksShelfs[ShelfNo].Books.Length;)
                    { 
                        if (Racks[RackNo].BooksShelfs[ShelfNo].Books[i] == null)
                        {
                            Racks[RackNo].BooksShelfs[ShelfNo].Books[i] = Ubook; 
                        }
                        break;
                     }
                }
            }
        }
    }

    public class Rack
    {
        public int numberOfShelf;
        public Shelf[] BooksShelfs;
        public int RackNumber;

        public Rack (int countofshelf, int countofbook, int racknumber)
        {
            numberOfShelf = countofshelf;
            BooksShelfs = new Shelf[countofshelf];
            RackNumber = racknumber;

           for (int i = 0; i < BooksShelfs.Length; i++)
            {
                BooksShelfs[i] = new Shelf(countofbook, i + 1);
            }
        }

        public void Print()
        {
            Console.WriteLine($"стелаж: {RackNumber}");
            for (int i = 0; i < BooksShelfs.Length; i++)
            {
                if (BooksShelfs[i] != null)
                {
                    BooksShelfs[i].Print();
                }
            }
        }
    }
    public class Shelf
    {
        public int numberOfBooks;
        public Book[] Books;
        public int ShelfNumber;

        public Shelf(int countofbook, int shelfnumber)
        {
            numberOfBooks = countofbook;
            Books = new Book[numberOfBooks];
            ShelfNumber = shelfnumber;
        }

        public void Print()
        {
            Console.WriteLine($"Полка #: {ShelfNumber}");
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null)
                {
                    Books[i].Print();
                }
            }
        }
    }

    public class Book
    {
        public string name;
        public string autor;
        public int numberOfPage;
       // public Shelf Parent;
        
        public Book(string n, string a, int p)
        {
            name = n;
            autor = a;
            numberOfPage = p;
        }

        public void Print()
        {
            Console.WriteLine($"{this.name}, {this.autor}, {this.numberOfPage}");
        }
    }
}
