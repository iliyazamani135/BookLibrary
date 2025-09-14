namespace Domain.Users
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User?> GetById(int id);
        Task<List<User?>> GetAll();
    }
}
