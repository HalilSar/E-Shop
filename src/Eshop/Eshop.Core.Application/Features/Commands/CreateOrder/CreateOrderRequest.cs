﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.CreateOrder
{
   public class CreateOrderRequest
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public double Total { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
