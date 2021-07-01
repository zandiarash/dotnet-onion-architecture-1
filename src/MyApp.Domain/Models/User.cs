﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Domain.Models
{
    public class User : AuditableEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
