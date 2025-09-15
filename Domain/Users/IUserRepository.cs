namespace Domain.Users
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User?> GetById(int id);
        Task<List<User?>> GetAll();
        Task<User?> GetByIdAsync(int userId);
        Task<List<User>> GetAllAsync();
    }
}
