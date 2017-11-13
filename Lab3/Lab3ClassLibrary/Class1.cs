using System;

namespace Lab3ClassLibrary
{
    public class Book
    {
        private Guid Id { get; set; }
        private string Title { get; set; }
        private int Year { get; set; }
        private double Price { get; set; }
        private string Genre { get; set; }


        public Book(string title, int year, double price, string genre)
        {
            this.Id = Guid.NewGuid();

            if (title.Length > 100)
            {
                throw new ArgumentException("Max 100");
            }

            else
            {
                this.Title = title;
            }

            this.Year = year;

            this.Price = price;

            this.Genre = genre;
        }

        public Guid getId()
        {
            return this.Id;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public int getYear()
        {
            return this.Year;
        }

        public string getGenre()
        {
            return this.Genre;
        }

        public double getPrice()
        {
            return this.Price;
        }

    }
}
