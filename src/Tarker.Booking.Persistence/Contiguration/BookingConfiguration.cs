using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Booking;

namespace Tarker.Booking.Persistence.Contiguration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<BookingEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(X => X.BookingId);
            entityTypeBuilder.Property(X => X.RegisterDate).IsRequired();
            entityTypeBuilder.Property(X => X.Code ).IsRequired();
            entityTypeBuilder.Property(X => X.Type ).IsRequired();
            entityTypeBuilder.Property(X => X.UserId ).IsRequired();
            entityTypeBuilder.Property(X => X.CustomerId ).IsRequired();

            entityTypeBuilder.HasOne(x => x.User)
                             .WithMany(x => x.Bookings)
                             .HasForeignKey(x => x.UserId);

            entityTypeBuilder.HasOne(x => x.Customer)
                             .WithMany(x => x.Bookings)
                             .HasForeignKey(x => x.CustomerId);
        }
    }
}
