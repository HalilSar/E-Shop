﻿using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdProduct
{
    public class GetByIdProductHandler : IRequestHandler<GetByIdProductRequest, GetByIdProductResponse>
    {
        IProductRepository _productRepository;
        IMapper _mapper;
        public GetByIdProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
	// Returns GetByIdProductResponse
	// Parameters: CancellationToken cancellationToken, GetByIdProductRequest request
        public async Task<GetByIdProductResponse> Handle(GetByIdProductRequest request, CancellationToken cancellationToken)
        {
            var product =await _productRepository.GetById(request.Id);
            return _mapper.Map<GetByIdProductResponse>(product);

        }
    }
}
