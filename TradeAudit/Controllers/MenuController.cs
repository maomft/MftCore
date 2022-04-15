using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TradeAuditService;
using TradeAuditService.Models.WebApiResult.Login;
using TradeAuditWeb.Models;

namespace TradeAuditWeb.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class MenuController : Controller
    {
        //可以考虑通过配置文件实现
        private Dictionary<string, string> menuCodeUrl = new Dictionary<string, string>()
        {
            {"交易审批","/TaskNodeL/MobileGetTaskNodeLstByPageView" }
        };

        public IActionResult GetCurrentUserMenu()
        {
            var menus = HttpContext.User.FindFirst(Consts.MenusClaimType);

            var menuModels = JsonConvert.DeserializeObject<List<MenuInfo>>(menus.Value);

            var menuViwModels = new List<MuneViewModel>();

            foreach (var menuModel in menuModels)
            {
                menuViwModels.Add(new MuneViewModel()
                {
                    C = menuModel.C,
                    N = menuModel.N,
                    Href = GetUrl(menuModel.C)??"/Menu/PageNotFound"
                });
            }
            
            return Json(menuViwModels);
        }

        //public IActionResult Redirect(string menuCode)
        //{
        //    if (string.IsNullOrEmpty(menuCode)) throw new TradeAuditService.ApplicationException("MenuCode不能为空");
        //    string url = GetUrl(menuCode);

        //    return Redirect(url);
        //}

        public string GetUrl(string menuCode)
        {
            return menuCodeUrl.GetValueOrDefault(menuCode);
        }
    }
}
