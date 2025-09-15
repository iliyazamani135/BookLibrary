using Domain.Apartments;
using Domain.Users;
using Domain.Bookings;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
