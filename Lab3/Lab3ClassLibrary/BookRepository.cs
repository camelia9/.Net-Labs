using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab3ClassLibrary;

namespace Lab3ClassLibrary
{
    public class BookRepository
    {

        private List<Book> Books { get; set; }

        public BookRepository(List<Book> books)
        {
            this.Books = books;
        }

        public IEnumerable<Book> RetriveAllBooks()
        {
            foreach (var book in Books)
                yield return book;
        }

        public IEnumerable<Book> RetriveAllOrderByYearDescending()
        {
            return Books.OrderByDescending(book => book.getYear());
        }

        public IEnumerable<Book> RetriveAllOrderByYearAscending()
        {
            return Books.OrderBy(book => book.getYear());
        }

        public IEnumerable<Book> RetriveAllOrderByPriceDescending()
        {
            return Books.OrderByDescending(book => book.getPrice());

        }
    
        public IEnumerable<IGrouping<string, Book>> RetriveAllBooksGroupedByGenre()
        {
            return Books.GroupBy(x => x.getGenre()).Select(x => x);
        }


    }
}

