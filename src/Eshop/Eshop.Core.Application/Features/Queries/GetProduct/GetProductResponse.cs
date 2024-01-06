using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetProduct
{
    public class GetProductResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
    }
}
