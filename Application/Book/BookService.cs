using Domain.Book;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Book?> GetByIdAsync(int id)
    {
        return await _bookRepository.GetByIdAsync(id);
    }

    public async Task<List<Book>> GetAllAsync()
    {
        return await _bookRepository.GetAllAsync();
    }

    public async Task ReserveBookAsync(int bookId, int userId)
    {
        
    }
}
