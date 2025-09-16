using Domain.Borrowings;
using Domain.Book;
using Application.Abstractions;

public class BorrowingService : IBorrowingService
{
    private readonly IBorrowingRepository _borrowingRepository;
    private readonly IBookRepository _bookRepository;
    private readonly IUnitOfWork _unitOfWork;

    public BorrowingService(
        IBorrowingRepository borrowingRepository,
        IBookRepository bookRepository,
        IUnitOfWork unitOfWork)
    {
        _borrowingRepository = borrowingRepository;
        _bookRepository = bookRepository;
        _unitOfWork = unitOfWork;
    }

    
    public async Task ReserveBookAsync(Guid bookId, Guid userId, DateTime start, DateTime end)
    {
        var book = await _bookRepository.GetByIdAsync(bookId);
        if (book == null || !book.IsAvailable)
            throw new InvalidOperationException("Book not available");

        var borrowing = new Borrowing(bookId, userId, new DateRange(start, end));
        await _borrowingRepository.AddAsync(borrowing);

        book.Borrow();
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<List<Borrowing>> GetUserBorrowingsAsync(Guid userId)
    {
        return await _borrowingRepository.GetUserBorrowingsAsync(userId);
    }
}
