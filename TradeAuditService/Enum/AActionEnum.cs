namespace TradeAuditWeb.WebApi
{
    /// <summary>
    /// 审批动作,传的为 审批前检查返回的审批动作
    /// </summary>
    public enum AActionEnum
    {
        /// <summary>
        /// 直接同意
        /// </summary>
        AgreeDirectly = 0,

        /// <summary>
        /// 同意继续
        /// </summary>
        AgreeContinue = 1,

        /// <summary>
        /// 拒绝
        /// </summary>
        Refuse = 2,

        /// <summary>
        /// 会签拒绝
        /// </summary>
        CountersignRefused = 3,

        /// <summary>
        /// 代签复核
        /// </summary>
        AllographReAudit = 4,

        /// <summary>
        /// 同意审批
        /// </summary>
        AgreeAudit = 5,

    }
}