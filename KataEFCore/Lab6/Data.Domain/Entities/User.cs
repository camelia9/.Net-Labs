using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using EnsureThat;

namespace Data.Domain.Entities
{
    public class User
    {
        private User()
        {
            
        }
        [Key]
        public Guid Id { get; private set; }
        [Required]
        public string FirstName { get; private set; }
        [Required]
        public string LastName { get; private set; }
        [Required, EmailAddress]
        public string Email { get; private set; }

        public static User Create(string firstName, string lastName, string email)
        {
            //Ensure.That(firstName).IsNotNullOrEmpty();
            //Ensure.That(lastName).IsNotEmpty();
            //Ensure.That(email).IsNotEmpty();
            var instance = new User { Id = Guid.NewGuid() };
            instance.Update(firstName, lastName, email);
            return instance;
        }

        public void Update(string firstName, string lastName, string email)
        {
            //Ensure.That(firstName).IsNotNullOrEmpty();
            //Ensure.That(lastName).IsNotEmpty();
            //Ensure.That(email).IsNotEmpty();
            FirstName = firstName;
            LastName = lastName;
            Email = email;

        }
    }

   
}
