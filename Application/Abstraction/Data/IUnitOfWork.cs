namespace Data;
public interface IUnitOfWork
{
    Task CommitAsync();
}
