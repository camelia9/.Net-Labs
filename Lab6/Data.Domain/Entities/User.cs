using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Domain.Entities
{
    public class User
    {
        public  Guid Id { set; get; }
        [Required]
        public  string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [EmailAddress]
        public string Email { set; get; }

        public User(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
