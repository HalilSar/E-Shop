using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdCustomer
{
    public class GetByEmailPasswordCustomerStatusRequest : IRequest<GetByEmailPasswordCustomerStatusResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
