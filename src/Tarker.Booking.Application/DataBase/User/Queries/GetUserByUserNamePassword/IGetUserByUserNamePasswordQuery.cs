namespace Tarker.Booking.Application.DataBase.User.Queries.GetUserByUserNamePassword
{
    public interface IGetUserByUserNamePasswordQuery
    {
        Task<GetUserByUserNamePasswordModel> Execute(string userName,
            string password);
    }
}
