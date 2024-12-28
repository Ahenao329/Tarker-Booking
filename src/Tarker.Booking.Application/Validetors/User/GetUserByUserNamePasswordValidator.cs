using FluentValidation;

namespace Tarker.Booking.Application.Validetors.User
{
    public class GetUserByUserNamePasswordValidator: AbstractValidator<(string, string)>
    {
        public GetUserByUserNamePasswordValidator()
        {
            RuleFor(x => x.Item1).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.Item2).NotNull().NotEmpty().MaximumLength(10);
        }
    }
}
