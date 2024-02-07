using BurnsMidterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTest
{
    public class BookStoreFunctionsTest
    {
        [Fact]
        public void GetBookByTitleTest()
        {
            var result = BookstoreFunctions.GetBookByTitle("The Travels of Marco Polo ");
            Assert.True(result.YearOfRelease == 1305);
        }

        [Fact]
        public void GetAllBooks()
        {
            var result = BookstoreFunctions.GetAllBooks();
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void GetAllBooksByAuthor()
        {
            var result = BookstoreFunctions.GetAllBooksByAuthor();
            Assert.True(result.Count == 1);
        }


    }
}
