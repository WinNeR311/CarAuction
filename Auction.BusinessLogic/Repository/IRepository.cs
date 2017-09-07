using Auction.Data.Entities;
using System.Collections.Generic;

namespace Auction.BusinessLogic.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetByLogin(string login);
        void SaveChanges();
    }
}
