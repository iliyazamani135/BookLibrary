namespace Domain.Abstract
{
    public interface IUbitOfWork
    {
        Task CommitAsync();
    }
}
