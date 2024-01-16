using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductRequest, List<GetProductResponse>>
    {

        IProductRepository _productRepository;
        IMapper _mapper;
        public GetProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }
        public async Task<List<GetProductResponse>> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            var products =await  _productRepository.Get();
            return  _mapper.Map<List<GetProductResponse>>(products);
           
        }
    }
}
