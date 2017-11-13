using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary1
{
    public class TodoRepositoryQuery
    {
        private List<Todo> todos = new List<Todo>();

        public TodoRepositoryQuery(List<Todo> todos)
        {
            this.todos = todos;
        }

        public List<Todo> RetriveActiveTodos()
        {
            var result = from i in todos
                where i.isActive()
                select i;

            return result.ToList();
        }

        public List<Todo> RetriveInactiveTodos()
        {
            var result = from i in todos
                where !i.isActive()
                select i;

            return result.ToList();
        }

        public List<Todo> RetriveAllOrderByStartDateDescending()
        {
            var result = from i in todos
                orderby i.getStartDate() descending
                select i;

            return result.ToList();
        }

        public List<Todo> RetriveAllOrderByStartDateAscending()
        {
            var result = from i in todos
                orderby i.getStartDate() 
                select i;

            return result.ToList();
        }

        public List<Todo> RetriveAllOrderByStartDateAndActiveAscending()
        {
            var currentDate = DateTime.Now;
            var result = from i in todos
                orderby i.getStartDate(), i.isActive()
                         select i;

            return result.ToList();

        }

        public List<Todo> RetriveAllOrderByStartDateAndInactiveDescending()
        {
            var currentDate = DateTime.Now;
            var result = from i in todos
                orderby i.getStartDate() descending, !i.isActive() descending 
                select i;

            return result.ToList();

        }
    }
}
