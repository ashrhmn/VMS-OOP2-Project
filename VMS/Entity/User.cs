using System;
using System.Collections.Generic;
using System.Text;

namespace VMS.Entity
{
    class User
    {
        string username;
        string password;
        string role;

        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
