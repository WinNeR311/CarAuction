using System;

namespace Auction.Data.Entities
{
    public class Lot : BaseEntity
    {
        public string Name { get; set; }
        public double StartPrice { get; set; }
        public double MinStep { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Car Car { get; set; }
        public User OwnerUser { get; set; }
        public User LastUpdatedUser { get; set; }
    }
}
