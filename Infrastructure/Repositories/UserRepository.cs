using Domain.Users;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context) { }

    public Task<List<User?>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetById(int id)
    {
        throw new NotImplementedException();
    }
}
