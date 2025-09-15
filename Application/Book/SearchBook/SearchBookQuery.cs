using Application.Abstraction.Messaging;
using Domain.Book;

public sealed class SearchBookQuery : IQuery<List<Book>>
{
    public string? Title { get; }
    public string? Author { get; }

    public SearchBookQuery(string? title = null, string? author = null)
    {
        Title = title;
        Author = author;
    }
}
