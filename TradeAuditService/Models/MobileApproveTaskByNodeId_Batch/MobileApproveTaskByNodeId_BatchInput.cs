using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.MobileApproveTaskByNodeId_Batch
{
    public class MobileApproveTaskByNodeId_BatchInput
    {
        /// <summary>
        /// 审批任务编号列表    审批节点编号列表，英文逗号分隔,NID编号
        /// </summary>
        public string aNodeIds { get; set; }

        /// <summary>
        /// 审批类型 交易审批 OTCTRADE
        /// </summary>
        public string targetType { get; set; } = "OTCTRADE";

        /// <summary>
        ///    登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        ///  直接同意 0，同意继续 1，拒绝 2，会签拒绝 3，代签复核 4，同意审批 5
        ///  传的为 审批前检查返回的审批动作
        /// </summary>
        public string aAction { get; set; }

        /// <summary>
        ///  备注
        /// </summary>
        public string actionNote { get; set; }

        /// <summary>
        ///  会签角色    会签角色编号，英文逗号分隔，默认空
        /// </summary>
        public string aCCRoles { get; set; }

        /// <summary>
        ///     数据类型 等待审批0，待会签1,提前审批2,补审批3,已审核4,已会签5,等待签核6,已签核7,我的提交9
        /// </summary>
        public string aDataTypeCurrent { get; set; } = "0";

    }
}
