using Domain.Book;

public class SearchBookQueryHandler : IQueryHandler<SearchBookQuery, List<Book>>
{
    private readonly IBookRepository _bookRepository;

    public SearchBookQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<Book>> HandleAsync(SearchBookQuery query)
    {
        var books = await _bookRepository.GetAllAsync();

        if (!string.IsNullOrEmpty(query.Title))
            books = books.Where(b => b.Title.Contains(query.Title, StringComparison.OrdinalIgnoreCase)).ToList();

        if (!string.IsNullOrEmpty(query.Author))
            books = books.Where(b => b.Author.Contains(query.Author, StringComparison.OrdinalIgnoreCase)).ToList();

        return books;
    }
}
