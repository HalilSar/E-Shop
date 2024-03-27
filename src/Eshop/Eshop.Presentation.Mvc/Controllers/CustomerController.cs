using Eshop.Core.Application.Features.Commands.CreateCustomer;
using Eshop.Core.Application.Features.Commands.UpdateCustomer;
using Eshop.Core.Application.Features.Queries.GetByEmailPasswordCustomerStatus;
using Eshop.Core.Application.Features.Queries.GetByIdCustomer;
using Eshop.Presentation.Mvc.Utility;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(GetByEmailPasswordCustomerStatusRequest request)
        {
            
            var response = _mediatR.Send(request);
            if (response.Result.CustomerStatus == true)
            {
                CookieHelper.SetUserInfo(HttpContext, request);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
