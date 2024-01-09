using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustomerIdOrders
{
   public class GetByCustomerIdOrdersResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public double Total { get; set; }
    }
}
