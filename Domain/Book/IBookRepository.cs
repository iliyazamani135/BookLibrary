using Domain.Book;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(Guid id);
    Task<List<Book>> GetAllAsync();
    Task AddAsync(Book book);
    Task UpdateAsync(Book book);
    Task DeleteAsync(Book book);
}
