using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustormerIdCartItem
{
    public  class GetByCustormerIdCartItemResponse
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double SubTotal { get; set; }
    }
}
