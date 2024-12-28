
namespace Tarker.Booking.Application.DataBase.User.Queries.GetUserByUserNamePassword
{
    public class GetUserByUserNamePasswordModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
    }
}
