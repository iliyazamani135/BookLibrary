﻿using Domain.Book;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(int id);
    Task<List<Book>> GetAllAsync();
    Task AddAsync(Book book);
   
}
