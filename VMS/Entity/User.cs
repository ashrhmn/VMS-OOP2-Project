using System;
using System.Collections.Generic;
using System.Text;

namespace VMS.Entity
{
    class User
    {
        string _username;
        string _password;
        string _role;

        public User()
        {

        }

        public User(string username, string password, string role)
        {
            this._username = username;
            this._password = password;
            this._role = role;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
