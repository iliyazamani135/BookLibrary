using Domain.Entities;

namespace Domain.Borrowings
{
    public sealed class Borrowing : EntityBase
    {
        private int bookId;
        private int userId;
        private DateRange dateRange;

        public Guid BookId { get; private set; }
        public Guid UserId { get; private set; }
        public DateRange BorrowPeriod { get; private set; }
        public BorrowingStatus Status { get; private set; }

        public Borrowing(Guid bookId, Guid userId, DateRange period)
        {
            BookId = bookId;
            UserId = userId;
            BorrowPeriod = period;
            Status = BorrowingStatus.Pending;
        }

        public Borrowing(int bookId, int userId, DateRange dateRange)
        {
            this.bookId = bookId;
            this.userId = userId;
            this.dateRange = dateRange;
        }

        public void Confirm() => Status = BorrowingStatus.Confirmed;
        public void Cancel() => Status = BorrowingStatus.Cancelled;
    }
}
