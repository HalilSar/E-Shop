using Eshop.Core.Domain.Abstracts;
using System.Collections.Generic;

namespace Eshop.Core.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
