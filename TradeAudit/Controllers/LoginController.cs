using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TradeAuditService;
using TradeAuditService.WebApi.Login;
using TradeAuditWeb.WebApi;

namespace TradeAuditWeb.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult LoginIn()
        {
            //代码测试
            
            return View();
        }

        [HttpPost]
        public async Task LoginIn([FromForm] LoginInInput input)
        {
            if (string.IsNullOrEmpty(input.aUserCode)) throw new TradeAuditService.ApplicationException("账户不能为空");
            if (string.IsNullOrEmpty(input.aPwd)) throw new TradeAuditService.ApplicationException("密码不能为空");

            input.aPwd = input.aPwd.Trim();
            input.aUserCode = input.aUserCode.Trim();

            WebApi.TradeAuditAppService loginService = new WebApi.TradeAuditAppService();
            var outPut = loginService.LoginIn(input);

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(Consts.UserCodeClaimType, outPut.aUserCode));
            claims.Add(new Claim(Consts.PasswordClaimType, outPut.aPwd));
            claims.Add(new Claim(Consts.MenusClaimType, JsonConvert.SerializeObject(outPut.Menus)));

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

            //return Redirect("/Home/Index");

        }
        public IActionResult LoginOut()
        {
            var httpCurrent = HttpContext.User;

            return View();
        }
    }
}
