using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.UpdateCustomer
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerRequest, UpdateCustomerResponse>
    {
        ICustomerRepository _customerRepository;
        IMapper _mapper;
        public UpdateCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
       }
       // Return     : UpdateCustomerResponse
       // Parameters : UpdateCustomerRequest request, CancellationToken cancellationToken 
        public async Task<UpdateCustomerResponse> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
           var customer = _mapper.Map<Customer>(request);
           await _customerRepository.Update(customer);
            return new UpdateCustomerResponse { Success = "Başarılı" };
        }
    }
}
