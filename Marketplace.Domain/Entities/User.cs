using Marketplace.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Marketplace.Domain.Entities
{
    public class User
    {
        public Guid Id { get;private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get;private set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.RegularUser;
        public DateTime CreatedAt { get; private set; }

        private User() { 
        }
        public User(string firstName, string lastName, string email, string passwordHash, UserRole userRole)
        {
            if(string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("First name cannot be empty.", nameof(firstName));
            if(string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Last name cannot be empty.", nameof(lastName));

            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            Role = userRole;
            CreatedAt = DateTime.UtcNow;
        }

    }
}
