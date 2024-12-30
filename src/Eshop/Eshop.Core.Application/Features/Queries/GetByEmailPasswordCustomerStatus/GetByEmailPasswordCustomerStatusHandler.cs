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

namespace Eshop.Core.Application.Features.Queries.GetByEmailPasswordCustomerStatus
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
	// Return     : GetByEmailPasswordCustomerStatusResponse
	// Parameters : GetByEmailPasswordCustomerStatusRequest request, CancellationToken cancellationToken
        public async Task<GetByEmailPasswordCustomerStatusResponse> Handle(GetByEmailPasswordCustomerStatusRequest request, CancellationToken cancellationToken)
        {
            var customerStatus = await _customerRepository.Login(_mapper.Map<Customer>(request));
            return new GetByEmailPasswordCustomerStatusResponse { CustomerStatus = customerStatus}; 
        }
    }
}
