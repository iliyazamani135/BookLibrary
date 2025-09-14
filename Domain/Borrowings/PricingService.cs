namespace Domain.Borrowings
{
    public sealed class PricingService
    {
        private readonly decimal _lateFeePerDay = 1m;
        public decimal CalculateLateFee(DateTime dueDate, DateTime returnedDate)
        {
            var daysLate = (returnedDate - dueDate).Days;
            return daysLate > 0 ? daysLate * _lateFeePerDay : 0;
        }
    }
}
