using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdCustomer
{
    public class GetByIdCustomerHandler : IRequestHandler< GetByIdCustomerRequest,GetByIdCustomerResponse>
    {
        IMapper _mapper;
        ICustomerRepository _customerRepository;
        public GetByIdCustomerHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<GetByIdCustomerResponse> Handle(GetByIdCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetById(request.Id);
            return _mapper.Map<GetByIdCustomerResponse>(customer); 
        }
    }
}
