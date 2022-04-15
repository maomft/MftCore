using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService
{
    /// <summary>
    /// 提供静态变量
    /// </summary>
    public class Consts
    {
        /// <summary>
        /// 审批WebApi根地址
        /// </summary>
        internal const string TradeAuditRootUrl = @"http://191.168.0.95:9000/API/service/";

        public const string ModelStateErrorKey = "Error";

        public const string UserCodeClaimType = "aUserCode";
        public const string PasswordClaimType = "aPwd";
        public const string MenusClaimType = "Menus";
    }

}
