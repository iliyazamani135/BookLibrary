using Domain.Bookings;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class BookingRepository : Repository<Booking>, IBookingRepository
{
    public BookingRepository(ApplicationDbContext context) : base(context) { }
}
