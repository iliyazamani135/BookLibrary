using Application.Abstractions;
using Domain.Book;
using Domain.Borrowings;

public class ReserveBookCommandHandler : ICommandHandler<ReserveBookCommand>
{
    private readonly IBookRepository _bookRepository;
    private readonly IBorrowingRepository _borrowingRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ReserveBookCommandHandler(
        IBookRepository bookRepository,
        IBorrowingRepository borrowingRepository,
        IUnitOfWork unitOfWork)
    {
        _bookRepository = bookRepository;
        _borrowingRepository = borrowingRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task HandleAsync(ReserveBookCommand command)
    {
        var book = await _bookRepository.GetByIdAsync(command.BookId);
        if (book == null || !book.IsAvailable)
            throw new InvalidOperationException("Book not available");

        var borrowPeriod = new DateRange(command.Start, command.End);
        var borrowing = new Borrowing(command.BookId, command.UserId, borrowPeriod);

        await _borrowingRepository.AddAsync(borrowing);
        book.Borrow();

        await _unitOfWork.SaveChangesAsync();
    }
}
