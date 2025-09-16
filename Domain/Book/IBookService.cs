using Domain.Book;
using System;
using System.Threading.Tasks;

public interface IBookService
{
    Task<Book?> GetByIdAsync(Guid id);
    Task<List<Book>> GetAllAsync();
    Task AddBookAsync(Book book);
    Task UpdateBookAsync(Book book);
    Task DeleteBookAsync(Book book);
}
