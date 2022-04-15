using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.MobileSingleTraceLog
{

    public class MobileSingleTraceLogInput
    {
        /// <summary>
        /// 登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        /// 审批任务ID,7.3方法中返回的TID编号
        /// </summary>
        public string aTaskId { get; set; }
    }
}
