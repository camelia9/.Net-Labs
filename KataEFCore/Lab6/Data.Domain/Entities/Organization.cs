using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EnsureThat;

namespace Data.Domain.Entities
{
    public class Organization
    {
        private Organization()
        {
            
        }
        [Key]
        public Guid Id { get;  set; }
        [Required]
        public string Name { get;  set; }
        [Required]
        public string Description { get;  set; }
        [Required]
        public List<User> UserList { get;  set; }
        [Required]
        public  string ActivityType { get; set; }


        public static Organization Create(string description, string name, List<User> userList)
        {
            Ensure.That(description).IsNotNullOrEmpty();
            Ensure.That(name).IsNotEmpty();
            var instance = new Organization { Id = Guid.NewGuid() };
            instance.Update(description, name, userList);
            return instance;
        }

        public void Update(string description, string name, List<User> userList) {
            Ensure.That(description).IsNotNullOrEmpty();
            Ensure.That(name).IsNotEmpty();
            Description = description;
            Name = name;
            UserList = userList;
        }
    }
}
