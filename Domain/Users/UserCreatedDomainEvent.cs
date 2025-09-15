using Domain.Abstract;

namespace Domain.Users
{
    public sealed class UserCreatedDomainEvent : IDomainEvent
    {
        public User User { get; }
        public DateTime OccuredOn { get; } = DateTime.UtcNow;

        public UserCreatedDomainEvent(User user)
        {
            User = user;
        }
    }
}
