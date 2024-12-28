using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Tarker.Booking.Application.DataBase.User.Queries.GetUserByUserNamePassword
{
    public class GetUserByUserNamePasswordQuery : IGetUserByUserNamePasswordQuery
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetUserByUserNamePasswordQuery(IDataBaseService DatabaseService, IMapper mapper)
        {
            _databaseService = DatabaseService;
            _mapper = mapper;
        }

        public async Task<GetUserByUserNamePasswordModel> Execute(string userName,
            string password)
        {
            var entity = await _databaseService.User.
                FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);
            return _mapper.Map<GetUserByUserNamePasswordModel>(entity);

        }
    }
}
