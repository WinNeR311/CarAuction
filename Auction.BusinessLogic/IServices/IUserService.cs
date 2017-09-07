using Auction.Data.Entities;

namespace Auction.BusinessLogic.IServices
{
    public interface IUserService
    {
        void CreateUser(User user);
        User GetUser(int id);
        void UpdateUser(User user);
        User LoginUser(string login, string password);
    }
}
