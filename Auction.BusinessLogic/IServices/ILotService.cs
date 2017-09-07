using Auction.Data.Entities;
using System.Collections.Generic;

namespace Auction.BusinessLogic.IServices
{
    public interface ILotService
    {
        void CreateLot(Lot lot);
        void UpdateLot(Lot lot);
        void CloseLot(Lot lot);
        IEnumerable<Lot> GetAllLots();
    }
}
