using Eshop.Core.Domain.Abstracts;

namespace Eshop.Core.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
