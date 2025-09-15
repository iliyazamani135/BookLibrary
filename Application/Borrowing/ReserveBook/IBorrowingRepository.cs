using Domain.Borrowings;

public interface IBorrowingRepository
{
    Task AddAsync(Borrowing borrowing); 
    Task<Borrowing?> GetByIdAsync(int id);
    Task<List<Borrowing>> GetAllAsync();
    Task<List<Borrowing>> GetUserBorrowingsAsync(int userId);
}