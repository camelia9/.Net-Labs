using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class TodoRepositoryMethod
    {
        private List<Todo> todos = new List<Todo>();

        public TodoRepositoryMethod(List<Todo> todos)
        {
            this.todos = todos;
        }

        
    }
}
