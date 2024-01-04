using Eshop.Core.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
