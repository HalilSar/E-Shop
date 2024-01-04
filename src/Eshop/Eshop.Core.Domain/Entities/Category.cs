using Eshop.Core.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
