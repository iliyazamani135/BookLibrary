using Infrastructure.Data;
using Domain.Book;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Abstractions;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IUnitOfWork _unitOfWork;

    public BookService(IBookRepository bookRepository, IUnitOfWork unitOfWork)
    {
        _bookRepository = bookRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Book?> GetByIdAsync(Guid id)
    {
        return await _bookRepository.GetByIdAsync(id);
    }

    public async Task<List<Book>> GetAllAsync()
    {
        return await _bookRepository.GetAllAsync();
    }

    public async Task AddBookAsync(Book book)
    {
        await _bookRepository.AddAsync(book);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateBookAsync(Book book)
    {
        await _bookRepository.UpdateAsync(book);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteBookAsync(Book book)
    {
        await _bookRepository.DeleteAsync(book);
        await _unitOfWork.SaveChangesAsync();
    }
}
