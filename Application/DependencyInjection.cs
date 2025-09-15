using Domain.Book;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IBorrowingService, BorrowingService>();

        
        services.AddScoped<ICommandHandler<ReserveBookCommand>, ReserveBookCommandHandler>();
        services.AddScoped<IQueryHandler<SearchBookQuery, List<Book>>, SearchBookQueryHandler>();

        
        services.AddSingleton<IClock, SystemClock>();
        services.AddScoped<IEmailSender, EmailSender>();

        services.AddScoped<IMediator, Mediator>();

        return services;
    }
}
