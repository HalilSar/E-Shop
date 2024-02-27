using AutoMapper;
using Eshop.Core.Application.Features.Commands.CreateCustomer;
using Eshop.Core.Application.Features.Commands.UpdateCustomer;
using Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct;
using Eshop.Core.Application.Features.Queries.GetByIdCustomer;
using Eshop.Core.Application.Features.Queries.GetByIdProduct;
using Eshop.Core.Application.Features.Queries.GetProduct;
using Eshop.Core.Application.Features.Queries.GetByCustomerIdOrder;

using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Core.Application.Features.Queries.GetByCustomerIdOrders;
using Eshop.Core.Application.Features.Commands.CreateOrder;
using Eshop.Core.Application.Features.Commands.CreateOrderProduct;
using Eshop.Core.Application.Features.Queries.GetByOrderIdOrderProduct;
using Eshop.Core.Application.Features.Queries.GetByCustormerIdCartItem;
using Eshop.Core.Application.Features.Commands.CreateCartItem;
using Eshop.Core.Application.Features.Commands.UpdateCartItem;
using Eshop.Core.Application.Features.Commands.DeleteCartItem;
using Eshop.Core.Application.Features.Queries.GetCategory;
using Eshop.Core.Application.Dto;

namespace Eshop.Core.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {

            CreateMap<GetByCategoryIdProductResponse,Product>().ReverseMap();
            CreateMap<GetByIdProductResponse,Product>().ReverseMap();
            CreateMap<GetProductDto, Product>().ReverseMap();

            CreateMap<GetByIdCustomerResponse, Customer>().ReverseMap();
            CreateMap<Customer, CreateCustomerRequest>().ReverseMap();
            CreateMap<Customer, UpdateCustomerRequest>().ReverseMap();

            CreateMap<GetByCustomerIdOrderResponse, Order>().ReverseMap();
            CreateMap<GetByCustomerIdOrdersResponse, Order>().ReverseMap();
            CreateMap< Order, CreateOrderRequest>().ReverseMap();

            CreateMap<OrderProduct, CreateOrderProductRequest>().ReverseMap();
            CreateMap<GetByOrderIdOrderProductResponse, OrderProduct>().ReverseMap();

            CreateMap<GetByCustormerIdCartItemResponse, CartItem>().ReverseMap();
            CreateMap<CartItem, CreateCartItemRequest>().ReverseMap();
            CreateMap<CartItem, UpdateCartItemRequest>().ReverseMap();
            CreateMap<CartItem, DeleteCartItemRequest>().ReverseMap();
            CreateMap<CartItem, CartItemDto>().ReverseMap();
            CreateMap<GetCategoryResponse, Category>().ReverseMap();


        }
    }
}
