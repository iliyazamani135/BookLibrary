using Domain.Entities;

namespace Domain.Users
{
    public sealed class User : EntityBase
    {
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }

        public User(string name, string lastname, string email)
        {
            Name = name;
            Lastname = lastname;
            Email = email;
        }
    }
}
