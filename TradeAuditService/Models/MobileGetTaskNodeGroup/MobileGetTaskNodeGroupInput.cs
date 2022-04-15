namespace TradeAuditService.Models.MobileGetTaskNodeGroup
{
    /// <summary>
    /// 7.10查询审批数据分组信息
    /// </summary>
    public class MobileGetTaskNodeGroupInput
    {
        /// <summary>
        ///  审批类型, 交易审批 OTCTRADE，
        /// </summary>
        public string aTargetType { get; set; } = "OTCTRADE";

        /// <summary>
        ///  登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        ///  起始日期    开始日期默认是当前日期往前14天
        /// </summary>
        public string aBeg_date { get; set; } = "2020-01-01";

        /// <summary>
        /// 结束日期 结束日期默认是当期日期往后1天
        /// </summary>
        public string aEnd_date { get; set; } = "2020-12-31";

        /// <summary>
        /// 类型
        /// </summary>
        public string aDataType { get; set; } = "0";
    }
}