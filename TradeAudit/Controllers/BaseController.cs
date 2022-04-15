using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TradeAuditService;

namespace TradeAuditWeb.Controllers
{
    public class BaseController : Controller
    {
        protected string GetCurrentUserCode()
        {
            System.Security.Claims.Claim userCodeClaim = HttpContext.User.FindFirst(Consts.UserCodeClaimType);

            return userCodeClaim.Value;
        }
    }
}
