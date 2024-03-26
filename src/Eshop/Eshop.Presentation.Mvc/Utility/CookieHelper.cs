using Eshop.Core.Application.Features.Queries.GetByEmailPasswordCustomerStatus;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.Utility
{
    public static class CookieHelper
    {
        
        public static void SetUserInfo(HttpContext context, GetByEmailPasswordCustomerStatusRequest request)
        {
            var options = new CookieOptions { Expires = DateTime.Now.AddDays(7), HttpOnly = true };
            context.Response.Cookies.Append("UserInfo", $"{request.Email}|{request.Password}",options);
        }
    }
}
