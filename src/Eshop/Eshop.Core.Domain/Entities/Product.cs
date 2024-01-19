using Eshop.Core.Domain.Abstracts;
using System.Collections.Generic;

namespace Eshop.Core.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
        public int Amount { get; set; }
        public Category Category { get; set; }
        public List<CartItem> CartItems { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

    }
}
