using System;
using Vacation.Core.Models;

namespace Vacation.Domain.Entities
{
    public class User : Entity
    {
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        protected User() { }

        public User(Guid id, string email, string firstName, string lastName)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}