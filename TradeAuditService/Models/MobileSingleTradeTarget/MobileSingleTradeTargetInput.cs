namespace TradeAuditService.Models.MobileSingleTradeTarget
{
    /// <summary>
    /// 7.6查询交易指标Input
    /// </summary>
    public class MobileSingleTradeTargetInput
    {
        /// <summary>
        /// 登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        /// 审批任务ID
        /// </summary>
        public string aTaskId { get; set; }
    }
}