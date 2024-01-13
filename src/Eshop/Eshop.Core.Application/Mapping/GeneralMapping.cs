using AutoMapper;
using Eshop.Core.Application.Features.Commands.CreateCustomer;
using Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct;
using Eshop.Core.Application.Features.Queries.GetByIdCustomer;
using Eshop.Core.Application.Features.Queries.GetByIdProduct;
using Eshop.Core.Application.Features.Queries.GetProduct;
using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<GetByCategoryIdProductResponse,Product>().ReverseMap();
            CreateMap<GetByIdProductResponse,Product>().ReverseMap();
            CreateMap<GetProductResponse, Product>().ReverseMap();

            CreateMap<GetByIdCustomerResponse, Customer>().ReverseMap();
            CreateMap<Customer, CreateCustomerRequest>().ReverseMap();


        }
    }
}
