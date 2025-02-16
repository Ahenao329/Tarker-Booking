﻿using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Domain.Entities.Booking;
using Tarker.Booking.Domain.Entities.Custumer;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }

        DbSet<BookingEntity> Booking { get; set; }
        Task<bool> SaveAsync();
    }
}
