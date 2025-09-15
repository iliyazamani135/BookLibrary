using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<TEntity> where TEntity : class
{
    protected readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity?> GetByIdAsync(int id)
        => await _context.Set<TEntity>().FindAsync(id);

    public async Task AddAsync(TEntity entity)
        => await _context.Set<TEntity>().AddAsync(entity);
}
