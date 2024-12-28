namespace Tarker.Booking.Application.DataBase.Bookings.Queries.GetBookingsByType
{
    public interface IGetBookingsByTypeQuery
    {
        Task<List<GetBookingsByTypeModel>> Execute(String type);
    }
}
