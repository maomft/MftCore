namespace TradeAuditService.Models.WebApiResult.CheckBeforeActionByNodeId_Batch
{
    /// <summary>
    /// 7.8批量审批前检查
    /// </summary>
    public class CheckBeforeActionByNodeId_BatchRT : RT
    {
       public Action Action { get; set; }
    }

    public class Action
    {
        /// <summary>
        /// 同意按钮是否可以点击  True 可以fase 不可以
        /// </summary>
        public bool ISAGREE { get; set; }

        /// <summary>
        ///    同意按钮名称 同意继续或直接同意
        /// </summary>
        public string AGREENAME { get; set; }

        /// <summary>
        ///  拒绝按钮是否可以点击  True 可以fase 不可以
        /// </summary>
        public bool ISREJECT { get; set; }
    }
}