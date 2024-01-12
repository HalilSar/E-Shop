using AutoMapper;
using Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct;
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
            CreateMap<GetByCategoryIdProductResponse,Product>().ReverseMap()s;


        }
    }
}
