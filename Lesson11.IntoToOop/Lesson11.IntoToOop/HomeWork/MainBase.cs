namespace Lesson11.IntoToOop.HomeWork
{
    public class MainBase
    {
        static void Main(string[] args)
        {
            BookLibrary library = new BookLibrary(2, 4, 10);
            library.AddBook(1, 2, new Book("Lev", "Ritual", 405));
            library.Print();
        }
    }
}