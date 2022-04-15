using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradeAuditService.WebApi.Login
{
    public class LoginInInput
    {
        /// <summary>
        /// 登录用户代码
        /// </summary>
        [Required(ErrorMessage = "请输入账户")]
        public string aUserCode { get; set; }

        /// <summary>
        /// 登录用户密码
        /// </summary>
        [Required(ErrorMessage = "请输入密码")]
        public string aPwd { get; set; }

        /// <summary>
        /// 登录手机MAC地址,默认传1
        /// </summary>
        public string aMAC { get; private set; } = "1";     
     
    }
}
