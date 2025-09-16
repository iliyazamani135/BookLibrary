using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Borrowings
{
    public interface IBorrowingRepository
    {
        Task AddAsync(Borrowing borrowing);                 
        Task<Borrowing?> GetByIdAsync(Guid id);           
        Task<List<Borrowing>> GetAllAsync();                
        Task<List<Borrowing>> GetUserBorrowingsAsync(Guid userId); 
        Task UpdateAsync(Borrowing borrowing);             
        Task DeleteAsync(Borrowing borrowing);              
    }
}
