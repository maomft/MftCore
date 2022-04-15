namespace TradeAuditService.Models.MobileCheckBeforeActionByNodeId_Batch
{
    public class MobileCheckBeforeActionByNodeId_BatchInput
    {
        /// <summary>
        /// 审批任务编号列表    审批节点列表，英文逗号分隔,7.3方法中返回的NID编号
        /// </summary>
        public string aNodeIds { get; set; }

        /// <summary>
        ///  审批类型 交易审批 OTCTRADE
        /// </summary>
        public string targetType { get; set; }

        /// <summary>
        ///  登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        ///  数据类型 等待审批0，待会签1,提前审批2,补审批3,已审核4,已会签5,等待签核6,已签核7,我的提交9
        /// </summary>
        public string aDataTypeCurrent { get; set; }
    }
}