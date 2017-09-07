using Auction.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace Auction.BusinessLogic.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly Context context;
        private IDbSet<T> _entities;

        public Repository(Context context)
        {
            this.context = context;
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = context.Set<T>();
                }
                return _entities;
            }
        }

        public T GetByLogin(string login)
        {
            return this._entities.Find(login);
        }

        public IEnumerable<T> GetAll()
        {
            return this._entities;
        }

        public T GetById(int id)
        {
            return this._entities.Find(id);
        }

        public void Create(T entity)
        {
            this._entities.Add(entity);
        }
        
        public void Delete(T entity)
        {
            this._entities.Remove(entity);
        }

        public void Update(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
