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
            _username = username;
            _password = password;
            _role = role;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
