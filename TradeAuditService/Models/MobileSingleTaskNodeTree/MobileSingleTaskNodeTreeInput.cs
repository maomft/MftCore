using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.MobileSingleTaskNodeTree
{
    /// <summary>
    /// 7.3查询单笔审批单审批流程图参数
    /// </summary>
    public class MobileSingleTaskNodeTreeInput
    {
        /// <summary>
        /// 登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        /// 审批任务ID,TID节点，审批编号,7.2接口查询的TID数据
        /// </summary>
        public string aTaskId { get; set; }
    }
}
