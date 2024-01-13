using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.UpdateCustomer
{
     public class UpdateCustomerRequest : IRequest<UpdateCustomerResponse>
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
