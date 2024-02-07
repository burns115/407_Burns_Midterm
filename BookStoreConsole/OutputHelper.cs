using BurnsMidterm.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookStoreConsole
{
    public class OutputHelper
    {
        public void WriteToConsole(List<Book> books)
        {
            Console.WriteLine("List of Books");
            foreach(var b in books)
            {
                Console.WriteLine($"BookID: {b.BookId}      Book Title: {b.BookTitle}       Genre ID: {b.GenreId}       Author ID: {b.AuthorId}     Year Released: {b.YearOfRelease}");
            }
        }

        public void WriteToCSV(List<Book> books)
        {
            using (var writer = new StreamWriter(@"..\file.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }
    }
}
