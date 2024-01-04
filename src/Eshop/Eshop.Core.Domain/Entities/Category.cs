using Eshop.Core.Domain.Abstracts;
using System.Collections.Generic;

namespace Eshop.Core.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
