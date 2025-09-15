using Domain.Book;

public interface IBookService
{
    Task<Book?> GetByIdAsync(int id);
    Task<List<Book>> GetAllAsync();
    Task ReserveBookAsync(int bookId, int userId);
}
