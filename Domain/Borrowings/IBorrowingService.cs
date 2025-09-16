using Domain.Borrowings;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IBorrowingService
{
    Task ReserveBookAsync(Guid bookId, Guid userId, DateTime start, DateTime end);
    Task<List<Borrowing>> GetUserBorrowingsAsync(Guid userId);
}
