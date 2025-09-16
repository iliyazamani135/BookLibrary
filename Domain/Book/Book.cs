using Domain.Entities;

namespace Domain.Book
{
    public sealed class Book : EntityBase
    {
        public object Name;

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; }
        public Money Price { get; private set; }
        public bool IsAvailable { get; private set; } = true;

        public Book(string title, string author, string description, Money price)
        {
            Title = title;
            Author = author;
            Description = description;
            Price = price;
        }

        public void Borrow()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("Book is already borrowed.");

            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        
        public void UpdateDetails(string title, string description, Money price)
        {
            Title = title;
            Description = description;
            Price = price;
        }
    }
}
