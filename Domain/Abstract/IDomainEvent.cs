namespace Domain.Abstract
{
    public interface IDomainEvent
    {
        DateTime OccuredOn { get; }
    }
}
