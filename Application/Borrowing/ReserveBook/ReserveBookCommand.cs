using Application.Abstraction.Messaging;

public sealed class ReserveBookCommand : ICommand
{
    public int BookId { get; }
    public int UserId { get; }
    public DateTime Start { get; }
    public DateTime End { get; }

    public ReserveBookCommand(int bookId, int userId, DateTime start, DateTime end)
    {
        BookId = bookId;
        UserId = userId;
        Start = start;
        End = end;
    }
}
