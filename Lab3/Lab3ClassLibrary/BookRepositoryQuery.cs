using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab3ClassLibrary;

namespace Lab3ClassLibrary
{
    public class BookRepositoryQuery
    {

        private List<Book> Books { get; set; }

        public BookRepositoryQuery(List<Book> books)
        {
            this.Books = books;
        }

    public IEnumerable<Book> RetriveAllBooks()
        {
            return from book in Books select book;
    }

        public IEnumerable<Book> RetriveAllOrderByYearDescending()
        {
            return from book in Books
                         orderby book.getYear() descending
                select book;
        }

        public IEnumerable<Book> RetriveAllOrderByYearAscending()
        {
            return from book in Books
                orderby book.getYear()
                   select book;
        }

        public IEnumerable<Book> RetriveAllOrderByPriceDescending()
        {
            return from book in Books
                orderby book.getPrice() descending
                select book;

        }

        public IEnumerable<IGrouping<string, Book>> RetriveAllBooksGroupedByGenre()
        {
            return Books.GroupBy(x => x.getGenre()).Select(x => x);
        }

    }
}

