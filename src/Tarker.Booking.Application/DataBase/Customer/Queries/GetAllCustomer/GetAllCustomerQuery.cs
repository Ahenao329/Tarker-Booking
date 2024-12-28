
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Tarker.Booking.Application.DataBase.Customer.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery: IGetAllCustomerQuery
    {
        public readonly IDataBaseService _DataBaseService;
        public readonly IMapper _Mapper;

        public GetAllCustomerQuery(IDataBaseService DataBaseService, IMapper Mapper)
        {
            _DataBaseService = DataBaseService;
            _Mapper = Mapper;
        }
        public async Task<List<GetAllCustomerModel>> Execute()
        {
            var ListEntities = await _DataBaseService.Customer.ToListAsync();
            return _Mapper.Map<List<GetAllCustomerModel>>(ListEntities);
        }
    }
}
