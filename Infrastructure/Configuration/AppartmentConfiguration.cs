using Domain.Book;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ApartmentConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
    }
}
