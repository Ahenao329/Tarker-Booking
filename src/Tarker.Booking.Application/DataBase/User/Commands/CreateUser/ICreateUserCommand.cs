using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Application.DataBase.User.Commands.CreateUser
{
    public interface ICreateUserCommand
    {
        public Task<CreateUserModel> Execute(CreateUserModel model);

    }
}
