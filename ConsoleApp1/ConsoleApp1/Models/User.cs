using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public User()
        {
            FullName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            IsActive = true;
            CreatedAt = DateTime.Now;
        }

        public User(String fullName, string email, string password, Role role)
        {
            FullName=fullName;
            Email=email;
            Password=password;
            Role=role;
            IsActive=true;
            CreatedAt=DateTime.Now;
        }
    }
}
