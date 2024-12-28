

namespace Tarker.Booking.Application.DataBase.Customer.DeleteCustomer
{
    public interface IDeleteCustomerCommand
    {
        Task<bool> Execute(int customerId);
    }
}
