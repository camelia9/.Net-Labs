using System;
using System.Collections.Generic;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public List<Todo> Sut()
        {
            List<Todo> todos = new List<Todo>();

            todos.Add(new Todo("Do1", "ToDo1", Convert.ToDateTime("13/10/2017"), 21));
            todos.Add(new Todo("Do2", "ToDo2", Convert.ToDateTime("17/10/2017"), 10));
            todos.Add(new Todo("Do3", "ToDo3", Convert.ToDateTime("16/10/2017"), 15));
            todos.Add(new Todo("Do4", "ToDo4", Convert.ToDateTime("11/10/2017"), 19));
            todos.Add(new Todo("Do5", "ToDo5", Convert.ToDateTime("16/10/2017"), 4));
            todos.Add(new Todo("Do6", "ToDo6", Convert.ToDateTime("17/10/2017"), 6));
            todos.Add(new Todo("Do7", "ToDo7", Convert.ToDateTime("29/10/2017"), 7));
            todos.Add(new Todo("Do8", "ToDo8", Convert.ToDateTime("30/10/2017"), 22));
            todos.Add(new Todo("Do9", "ToDo9", Convert.ToDateTime("23/11/2017"), 4));
            todos.Add(new Todo("Do10", "ToDo10", Convert.ToDateTime("9/11/2017"), 7));

            return todos;
        }

        

        

    }
}
