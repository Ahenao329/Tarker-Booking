using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Custumer;

namespace Tarker.Booking.Persistence.Contiguration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.CustomerId);
            entityTypeBuilder.Property(x => x.FullName).IsRequired();
            entityTypeBuilder.Property(x => x.DocumentNumber).IsRequired();

            entityTypeBuilder.HasMany(x => x.Bookings)
                 .WithOne(x => x.Customer)
                 .HasForeignKey(x => x.CustomerId);
        }
    }
}
