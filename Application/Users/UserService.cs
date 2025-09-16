using Application.Abstractions.Repositories;
using Domain.Users;


public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User?> GetByIdAsync(int userId)
    {
        return await _userRepository.GetByIdAsync(userId);
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _userRepository.GetAllAsync();
    }
}
