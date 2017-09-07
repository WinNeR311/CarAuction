using Auction.BusinessLogic.IServices;
using Auction.BusinessLogic.Repository;
using Auction.Data;
using System.Collections.Generic;

namespace Auction.BusinessLogic.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> _repository;
        public CarService(IRepository<Car> repository)
        {
            this._repository = repository;
        }
        public void AddCar(Car car)
        {
            _repository.Create(car);
            _repository.SaveChanges();
        }
        public Car GetCar(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<Car> GetAllCars()
        {
            return _repository.GetAll();
        }
        public void DeleteCar(int id)
        {
            _repository.Delete(_repository.GetById(id));
            _repository.SaveChanges();
        }
        public void PurchaseCar(Car car)
        {
            car.Model += " - SOLD";
            _repository.Update(car);
            _repository.SaveChanges();
        }
    }
}
