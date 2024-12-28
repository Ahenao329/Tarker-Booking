using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Domain.Entities.Booking;
using Tarker.Booking.Domain.Entities.Custumer;
using Tarker.Booking.Domain.Entities.User;
using Tarker.Booking.Persistence.Contiguration;

namespace Tarker.Booking.Persistence.DataBase
{
    public class DatabaseService: DbContext, IDataBaseService
    {
        public DatabaseService(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<UserEntity> User { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; } 
        public DbSet<BookingEntity> Booking { get; set; }
        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;    
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
            new BookingConfiguration(modelBuilder.Entity<BookingEntity>());
        }

    }
}
