using Eshop.Core.Domain.Abstracts;
namespace Eshop.Core.Domain.Entities
{
    public class OrderProduct : BaseEntity
    {

        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double SubTotal { get; set; }

    }
}
