using Eshop.Core.Application.Features.Commands.CreateCustomer;
using Eshop.Core.Application.Features.Commands.UpdateCustomer;
using Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct;
using Eshop.Core.Application.Features.Queries.GetByIdCustomer;
using Eshop.Core.Application.Features.Queries.GetByIdProduct;
using Eshop.Core.Application.Features.Queries.GetProduct;
using Eshop.Presentation.Mvc.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IMediator _mediatR;

        public CustomerController(ILogger<CustomerController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CreateCustomerRequest request)
        {
            return View(_mediatR.Send(request));
        }

        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateCustomerRequest request)
        {
            return View(_mediatR.Send(request));
        }
        public IActionResult GetCustomer(GetByIdCustomerRequest request)
        {
            var products = _mediatR.Send(request);
            return View(products);
        }

    }
}
