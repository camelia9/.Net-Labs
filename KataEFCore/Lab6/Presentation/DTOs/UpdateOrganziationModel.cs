using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Domain.Entities;

namespace Presentation.DTOs
{
    public class UpdateOrganziationModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<User> UserList { get; set; }
    }
}
