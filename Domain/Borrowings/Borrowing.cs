using Domain.Entities;

namespace Domain.Borrowings
{
    public sealed class Borrowing : EntityBase
    {
        public int BookId { get; private set; }
        public int UserId { get; private set; }
        public DateRange BorrowPeriod { get; private set; }
        public BorrowingStatus Status { get; private set; }

        public Borrowing(int bookId, int userId, DateRange period)
        {
            BookId = bookId;
            UserId = userId;
            BorrowPeriod = period;
            Status = BorrowingStatus.Pending;
        }

        public void Confirm() => Status = BorrowingStatus.Confirmed;
        public void Cancel() => Status = BorrowingStatus.Cancelled;
    }
}
