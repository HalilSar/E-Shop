using Eshop.Core.Domain.Abstracts;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Eshop.Core.Domain.Entities
{
    public class CartItem : BaseEntity 
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double SubTotal { get; set; }
    }
}
