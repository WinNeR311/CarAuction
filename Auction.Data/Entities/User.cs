using System;

namespace Auction.Data.Entities
{
    public class User :  BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HashCode { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
