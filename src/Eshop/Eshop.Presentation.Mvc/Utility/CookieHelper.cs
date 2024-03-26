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
            context.Response.Cookies.Append("UserInfo", $"{request.Email}",options);  // || $"{request.Email}|{request.CustomerName}   *
        }

        public static string GetUserInfo(HttpContext context)              //  ( string, string)   return type      **
        {
            if (context.Request.Cookies.TryGetValue("UserInfo",out string userInfo))
            {
                //   var parts = userInfo.Split('|'); and return (parts[1],parts[1] ;                             ***
                return userInfo;              
            }

            return null;  // (null, null);     ****
        }

        public static void RemoveUserInfo(HttpContext context) => context.Response.Cookies.Delete("UserInfo");

    }
}
