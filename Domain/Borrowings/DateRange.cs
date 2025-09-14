namespace Domain.Borrowings
{
    public sealed class DateRange
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public DateRange(DateTime start, DateTime end)
        {
            if (end <= start) throw new ArgumentException("End date must be after start date.");
            Start = start;
            End = end;
        }
    }

}
