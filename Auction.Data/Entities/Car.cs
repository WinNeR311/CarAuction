using Auction.Data.Entities;

namespace Auction.Data
{
    public class Car : BaseEntity
    {
        public CarModels Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public User Owner { get; set; }
    }
}
