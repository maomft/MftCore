using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeAuditService.Models.WebApiResult.Login;

namespace TradeAuditService.WebApi.Login
{
    public class LoginInOutput
    {
        /// <summary>
        /// 登入用户名
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        /// 登录用户密码
        /// </summary>
        public string aPwd { get; set; }

        /// <summary>
        /// 菜单栏
        /// </summary>
        public List<MenuInfo> Menus { get; set; }
    }
}
