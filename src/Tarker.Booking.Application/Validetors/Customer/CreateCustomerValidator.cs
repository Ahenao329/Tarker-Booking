using FluentValidation;
using Tarker.Booking.Application.DataBase.Customer.Commands.CreateCustomer;

namespace Tarker.Booking.Application.Validetors.Customer
{
    public class CreateCustomerValidator: AbstractValidator<CreateCustomerModel>
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.FullName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.DocumentNumber).NotNull().NotEmpty().Length(8);
        }   
    }
}
