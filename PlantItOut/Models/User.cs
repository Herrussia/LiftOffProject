namespace PlantItOut.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

    }
}