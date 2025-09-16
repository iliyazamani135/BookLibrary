using Application.Abstraction.Messaging;

public sealed class ReserveBookCommand : ICommand
{
    public Guid BookId { get; }
    public Guid UserId { get; }
    public DateTime Start { get; }
    public DateTime End { get; }

    public ReserveBookCommand(Guid bookId, Guid userId, DateTime start, DateTime end)
    {
        BookId = bookId;
        UserId = userId;
        Start = start;
        End = end;
    }
}

