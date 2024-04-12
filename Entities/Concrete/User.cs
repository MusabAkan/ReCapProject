﻿using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public User()
        {

        }
        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
