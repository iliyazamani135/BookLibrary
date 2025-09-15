using Application.Abstractions.Clock;
using Application.Abstractions.Email;
using Application.Abstractions.Data;
using Domain.Users;
using Domain.Book;
using Infrastructure.Clock;
using Infrastructure.Data;
using Infrastructure.Email;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dapper;



namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        
        SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());

        
        services.AddSingleton(new SqlConnectionFactory(connectionString));

        
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IBookingRepository, BookingRepository>();

        
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        
        services.AddScoped<IEmailService, EmailService>();

        return services;
    }
}
