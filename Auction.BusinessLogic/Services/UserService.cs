using Auction.BusinessLogic.IServices;
using Auction.BusinessLogic.Repository;
using Auction.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            this._repository = repository;
        }

        public void CreateUser(User user)
        {
            var newUser = user;
            using (var sha256 = SHA256.Create())
            {
                newUser.HashCode = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Email)).ToString();
            }
            _repository.Create(newUser);
            _repository.SaveChanges();
        }

        public User LoginUser(string login, string password)
        {
            var user = _repository.GetByLogin(login);
            if(user.Password == password)
            {
                return user;
            }
            else
            {
                throw new Exception("User not found");
            }
        }
        public void UpdateUser(User user)
        {
            _repository.Update(user);
            _repository.SaveChanges();
        }
        public User GetUser(int id)
        {
            return _repository.GetById(id);
        }
    }
}
