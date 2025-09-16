using Domain.Borrowings;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class BorrowingRepository : IBorrowingRepository
{
    private readonly ApplicationDbContext _context;

    public BorrowingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Borrowing borrowing)
    {
        await _context.Borrowings.AddAsync(borrowing);
        await _context.SaveChangesAsync();
    }

    public async Task<Borrowing?> GetByIdAsync(Guid id)
    {
        return await _context.Borrowings
            .AsNoTracking()
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task<List<Borrowing>> GetAllAsync()
    {
        return await _context.Borrowings
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<Borrowing>> GetUserBorrowingsAsync(Guid userId)
    {
        return await _context.Borrowings
            .AsNoTracking()
            .Where(b => b.UserId == userId)
            .ToListAsync();
    }

    public async Task UpdateAsync(Borrowing borrowing)
    {
        _context.Borrowings.Update(borrowing);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Borrowing borrowing)
    {
        _context.Borrowings.Remove(borrowing);
        await _context.SaveChangesAsync();
    }
}
