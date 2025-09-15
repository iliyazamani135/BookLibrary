using Domain.Borrowings;

public interface IBorrowingService
{
    Task ReserveBookAsync(int bookId, int userId, DateTime start, DateTime end);
    Task<List<Borrowing>> GetUserBorrowingsAsync(int userId);
}
