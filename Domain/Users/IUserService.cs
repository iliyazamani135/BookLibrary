using Domain.Users;

public interface IUserService
{
    Task<User?> GetByIdAsync(int userId);
    Task<List<User>> GetAllAsync();
}
