using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.MobileSingleLimitresult
{
    /// <summary>
    /// 7.5查询限额检查结果
    /// </summary>
    public class MobileSingleLimitresultInput
    {
        /// <summary>
        /// 登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        /// 审批任务ID,TID
        /// </summary>
        public string aTaskId { get; set; }

        /// <summary>
        /// 是否包含审批通过和交易执行的交易，默认值都传true
        /// </summary>
        public bool aIsIncludeConfirmed { get; set; } = true;

        /// <summary>
        /// 是否包括审批中的交易,，默认值都传true
        /// </summary>
        public bool aIsIncludeOrdered { get; set; } = true;

    }
}
