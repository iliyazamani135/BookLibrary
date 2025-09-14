namespace Domain.Book
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
        Task<Book?> GetById(int id);
        Task<List<Book?>> GetAllAsync();
    }
}
