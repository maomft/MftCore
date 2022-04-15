using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TradeAuditWeb.WebApi
{
    /// <summary>
    /// webapi方法所对应的枚举
    /// </summary>
    public enum AuditWebApiMethodEnum
    {
        /// <summary>
        /// 1.用户登录
        /// </summary>
        [Description("MobileLogon")]
        MobileLogon = 0,

        /// <summary>
        /// 2.分页查询审批数据列表信息
        /// </summary>
        [Description("MobileGetTaskNodeLstByPage")]
        MobileGetTaskNodeLstByPage = 1,

        /// <summary>
        /// 3.查询单笔审批单审批流程图
        /// </summary>
        [Description("MobileSingleTaskNodeTree")]
        MobileSingleTaskNodeTree = 2,

        /// <summary>
        /// 4.查询审批日志
        /// </summary>
        [Description("MobileSingleTraceLog")]
        MobileSingleTraceLog = 3,

        /// <summary>
        /// 5.查询限额检查结果
        /// </summary>
        [Description("MobileSingleLimitresult")]
        MobileSingleLimitresult = 4,

        /// <summary>
        /// 6. 查询交易指标
        /// </summary>
        [Description("MobileSingleTradeTarget")]
        MobileSingleTradeTarget = 5,

        /// <summary>
        /// 7.查询单笔交易详情
        /// </summary>
        [Description("MobileSingleTradeDetailNew")]
        MobileSingleTradeDetailNew = 6,

        /// <summary>
        /// 8.批量审批前检查
        /// </summary>
        [Description("MobileCheckBeforeActionByNodeId_Batch")]
        MobileCheckBeforeActionByNodeIdBatch = 7,

        /// <summary>
        /// 9. 批量审批操作 
        /// </summary>
        [Description("MobileApproveTaskByNodeId_Batch")]
        MobileApproveTaskByNodeIdBatch = 8,

        /// <summary>
        /// 10. 查询审批数据分组信息
        /// </summary>
        [Description("MobileGetTaskNodeGroup")]
        MobileGetTaskNodeGroup = 9,
    }
}
