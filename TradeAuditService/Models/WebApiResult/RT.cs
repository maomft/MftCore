using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult
{
    /// <summary>
    /// 每个接口方法返回的数据类型都需要实现这个类
    /// </summary>
    public class RT
    {
        public RE RE { get; set; }

    }
}
