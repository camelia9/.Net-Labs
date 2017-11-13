using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class Todo
    {
        private string ToDo { get; set; }
        private Guid Id { get; set; }
        private string Description { get; set; }
        private DateTime StartDate { get; set; }
        private double NumberOfDays { get; set; }


        public Todo(string toDo, string description, DateTime startDate, double numberOfDays)
        {
            this.Id = Guid.NewGuid();

            this.ToDo = toDo;

            this.Description = description;

            if (description.Length > 200)
            {
                throw new ArgumentException("Max 200");
            }

            this.StartDate = startDate;

            this.NumberOfDays = numberOfDays;
        }

        public Guid getId()
        {
            return this.Id;
        }

        public string getToDo()
        {
            return this.ToDo;
        }

        public string getDescription()
        {
            return this.Description;
        }

        public DateTime getStartDate()
        {
            return this.StartDate;
        }

        public double getNumberOfDays()
        {
            return this.NumberOfDays;
        }

        public bool isActive()
        {
            return (this.StartDate.AddDays(this.NumberOfDays) >= DateTime.Now && this.StartDate <= DateTime.Now);
        }
    }
}
