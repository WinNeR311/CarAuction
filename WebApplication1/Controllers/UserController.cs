using Auction.BusinessLogic.IServices;
using Auction.Data.Entities;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpPost]
        [Route("api/user/regiser")]
        public void CreateUser(User user)
        {
            _userService.CreateUser(user);
        }

        [HttpGet]
        [Route("api/user/login/{email}/{password}")]
        public User LoginUser(string email, string password)
        {
            return _userService.LoginUser(email, password);
        }

        [HttpPost]
        [Route("api/user/updateUser")]
        public void UpdateUser(User user)
        {
            _userService.UpdateUser(user);
        }


    }
}
