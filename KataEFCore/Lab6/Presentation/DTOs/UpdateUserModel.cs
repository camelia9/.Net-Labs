﻿using System;

namespace Presentation.DTOs
{
    public class UpdateUserModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
