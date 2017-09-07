using Auction.Data;
using System.Collections.Generic;

namespace Auction.BusinessLogic.IServices
{
    public interface ICarService
    {
        void AddCar(Car car);
        Car GetCar(int id);
        IEnumerable<Car> GetAllCars();
        void DeleteCar(int id);
        void PurchaseCar(Car car);
    }
}
