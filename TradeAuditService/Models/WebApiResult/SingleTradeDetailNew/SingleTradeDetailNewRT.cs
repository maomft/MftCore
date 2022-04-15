using System;
using System.Collections.Generic;
using System.Text;
using TradeAuditService.Models.WebApiResult.TaskNodeLst;

namespace TradeAuditService.Models.WebApiResult.SingleTradeDetailNew
{
    /// <summary>
    /// 7.7查询单笔交易详情
    /// </summary>
    public class SingleTradeDetailNewRT:RT
    {
        public Row Row { get; set; }
    }

    public class Row
    {
        public List<TaskNodeColumn> R { get; set; }
    }
}
