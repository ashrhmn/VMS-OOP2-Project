namespace VMS.Entity
{
    internal class User
    {
        public User()
        {
            //Do not remove the constructor even if it has 0 references, needed for LocalRepo.cs
        }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
