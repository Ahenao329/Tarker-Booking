using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Booking;

namespace Tarker.Booking.Application.DataBase.Customer.Commands.CreateCustomer
{
    public class CreateCustomerModel
    {
        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
    }
}
