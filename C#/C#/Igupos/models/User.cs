namespace Igupos.models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User() { }

        public User(int id, string name, string email, string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Role = role;    
        }
    }
}
