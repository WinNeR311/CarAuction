using Auction.BusinessLogic.IServices;
using Auction.BusinessLogic.Repository;
using Auction.Data.Entities;
using System.Collections.Generic;

namespace Auction.BusinessLogic.Services
{
    public class LotService : ILotService
    {
        private readonly IRepository<Lot> _repository;
        public LotService(IRepository<Lot> repository)
        {
            this._repository = repository;
        }
        public void CreateLot(Lot lot)
        {
            _repository.Create(lot);
        }
        public IEnumerable<Lot> GetAllLots()
        {
            return _repository.GetAll();
        }
        public void UpdateLot(Lot lot)
        {
            _repository.Update(lot);
            _repository.SaveChanges();
        }
        public void CloseLot(Lot lot)
        {
            _repository.Delete(lot);
            _repository.SaveChanges();
        }
    }
}
