using BurnsMidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnsMidterm
{
    public class BookstoreFunctions
    {
        public static Book GetBookByTitle(string title)
        {
            using(var db = new SE407_BookStoreContext())
            {
                return db.Books.Where(w => w.BookTitle == title).FirstOrDefault();
            }
        }

        public static List<Book> GetAllBooks()
        {
            using(var db = new SE407_BookStoreContext())
            {
                return db.Books.ToList();
            }
        }

        public static List<Book> GetAllBooksByAuthor()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books
                    .Join(db.Authors,
                    b => b.AuthorId,
                    a => a.AuthorId,
                    (b, a) => new
                    {
                        BookId = b.BookId,
                        BookTitle = b.BookTitle,
                        GenreId = b.GenreId,
                        AuthorLast = a.AuthorLast
                    }).Where(w => w.AuthorLast == "Polo")
                    .Select(b => new Book
                    {
                        BookId = b.BookId,
                        BookTitle = b.BookTitle,
                        GenreId = b.GenreId,
                    }).ToList();
            }
        }
    }
}
