using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Domain.Entities
{
    public class Organisation
    {
        public List<User> Users { set; get; }
        public Guid Id { set; get; }
        [Required]
        public string Name { set; get; }
        public string Description { set; get; }
    }
}
