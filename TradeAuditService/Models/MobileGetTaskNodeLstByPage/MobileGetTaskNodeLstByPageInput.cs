namespace TradeAuditService.Models.MobileGetTaskNodeLstByPage
{
    public class MobileGetTaskNodeLstByPageInput
    {
        /// <summary>
        ///  页数  从1开始
        /// </summary>
        public string aPage { get; set; }

        /// <summary>
        /// 审批类型 交易审批 OTCTRADE
        /// </summary>
        public string aTargetType { get; set; }

        /// <summary>
        /// 登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        /// 起始日期 开始日期默认是当前日期往前14天,格式2019-01-01
        /// </summary>
        public string aBegdate { get; set; }

        /// <summary>
        ///  结束日期    结束日期默认是当期日期往后1天，格式2019-01-01
        /// </summary>
        public string aEnddate { get; set; }

        /// <summary>
        ///    数据类型
        /// </summary>
        public int aDataType { get; set; }

        /// <summary>
        ///   审批单分组编号 组合传组合编号,单笔传 0
        /// </summary>
        public string aGroupCode { get; set; }
    }
}