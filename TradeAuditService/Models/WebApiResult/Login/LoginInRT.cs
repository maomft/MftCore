using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult.Login
{
    /// <summary>
    /// 登入webapi返回结果中的RT模型对象
    /// </summary>
    public class LoginInRT:RT
    {
        public List<MenuInfo> M { get; set; }
    }

    /// <summary>
    /// 菜单信息
    /// </summary>
    public class MenuInfo
    {
        /// <summary>
        /// 菜单代码
        /// </summary>
        public string C { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string N { get; set; }

        /// <summary>
        /// 是否有相关菜单权限,True有，false无
        /// </summary>
        public bool I { get; set; }
    }
}
