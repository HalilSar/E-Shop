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
    public class GetByEmailPasswordCustomerStatusHandler : IRequestHandler<GetByEmailPasswordCustomerStatusRequest, GetByEmailPasswordCustomerStatusResponse>
    {
        IMapper _mapper;
        ICustomerRepository _customerRepository;
        public GetByEmailPasswordCustomerStatusHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<GetByEmailPasswordCustomerStatusResponse> Handle(GetByEmailPasswordCustomerStatusRequest request, CancellationToken cancellationToken)
        {
            var customerStatus = await _customerRepository.Login(_mapper.Map<GetByEmailPasswordCustomerStatusRequest>(request));
            return new GetByEmailPasswordCustomerStatusResponse { CustomerStatus = customerStatus}; 
        }
    }
}
