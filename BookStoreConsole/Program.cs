using BurnsMidterm;
using System;

namespace BookStoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = BookstoreFunctions.GetAllBooks();
            var oh = new OutputHelper();
            oh.WriteToCSV(b);
        }

        //private static _operand();

        //static void Main()
        //{
        //    string[] args = Environment.GetCommandLineArgs();
        //    AreArgumentsValid(args);

        //    var functions = new BookstoreFunctions();
        //    switch (_operand)
        //    {
        //        case "all":
        //            Console.WriteLine($"BookID: {b.BookId}      Book Title: {b.BookTitle}       Genre ID: {b.GenreId}       Author ID: {b.AuthorId}     Year Released: {b.YearOfRelease}");
        //    }
        //}
    }
}