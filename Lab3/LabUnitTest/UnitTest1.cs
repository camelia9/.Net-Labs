using System;
using System.Collections.Generic;
using System.Linq;
using Lab3ClassLibrary;
using Xunit;

namespace LabUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestTitleLength()
        {
            Book book1;
            Assert.Throws<ArgumentException>(() => book1 = new Book(" I was actually trying to create (to use terms equivalent to OP's domain) SortedDictionary <PersonIdInt, SortedDictionary <CarNameString, CarInfoClass>>. The closest I could get using LINQ was IEnumerable <IGrouping <PersonIdInt, Dictionary <CarNameString, ", 2007, 25, "drama"));
        }

        [Fact]
        public void TestBook()
        {
            Book book1 = new Book(" I was actually trying", 2007, 25, "drama");
            Assert.Equal(book1.getGenre(),"drama");
            Assert.Equal(book1.getPrice(), 25);
            Assert.Equal(book1.getTitle(), "I was actually trying");
            Assert.Equal(book1.getYear(), 2007);
        }

        [Fact]
        public void TestBookRepository()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book(" I was actually trying", 2007, 25, "drama");
            Book book2 = new Book(" Comedy", 2008, 24, "comedy");
            Book book3 = new Book("Action book", 2006, 23, "action");
            Book book4 = new Book(" Drama book", 2005, 222, "drama");
            Book book5 = new Book("Drama book 2", 2004, 215, "drama");
            Book book6 = new Book("Action book 2", 2003, 257, "action");
            Book book7 = new Book("Drama book 3", 2002, 258, "drama");
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            books.Add(book6);
            books.Add(book7);
            BookRepository bookRepository = new BookRepository(books);
            Assert.Equal(bookRepository.RetriveAllBooks().ToList().Count, 7);
            Assert.Equal(bookRepository.RetriveAllOrderByPriceDescending().ElementAt(0), book7);
            Assert.Equal(bookRepository.RetriveAllOrderByYearAscending().ElementAt(0), book7);
            Assert.Equal(bookRepository.RetriveAllOrderByYearDescending().ElementAt(0), book2);
            Assert.Equal(bookRepository.RetriveAllOrderByYearDescending().ElementAt(0), book2);

        }

        [Fact]
        public void TestBookRepositoryQuery()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book(" I was actually trying", 2007, 25, "drama");
            Book book2 = new Book(" Comedy", 2008, 24, "comedy");
            Book book3 = new Book("Action book", 2006, 23, "action");
            Book book4 = new Book(" Drama book", 2005, 222, "drama");
            Book book5 = new Book("Drama book 2", 2004, 215, "drama");
            Book book6 = new Book("Action book 2", 2003, 257, "action");
            Book book7 = new Book("Drama book 3", 2002, 258, "drama");
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            books.Add(book6);
            books.Add(book7);
            BookRepositoryQuery bookRepository = new BookRepositoryQuery(books);
            Assert.Equal(bookRepository.RetriveAllBooks().ToList().Count, 7);
            Assert.Equal(bookRepository.RetriveAllOrderByPriceDescending().ToList().ElementAt(0), book7);
            Assert.Equal(bookRepository.RetriveAllOrderByYearAscending().ToList().ElementAt(0), book7);
            Assert.Equal(bookRepository.RetriveAllBooksGroupedByGenre().Count, 3);

        }

    }
}
