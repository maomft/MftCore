namespace TradeAuditService.Models.WebApiResult.MobileSingleLimitresult
{
    /// <summary>
    /// 7.5查询限额检查结果
    /// </summary>
    public class SingleLimitresultRT : RT
    {
        public LimitData L { get; set; }
    }

    /// <summary>
    /// 限额数据
    /// </summary>
    public class LimitData
    {
        /// <summary>
        /// 限额名称
        /// </summary>
        public string NA { get; set; }

        /// <summary>
        /// 限额类型
        /// </summary>
        public string TY { get; set; }

        /// <summary>
        /// 交易前结果
        /// </summary>
        public string BF { get; set; }

        /// <summary>
        /// 交易后结果
        /// </summary>
        public string AF { get; set; }

        /// <summary>
        /// 差值
        /// </summary>
        public string DF { get; set; }

        /// <summary>
        /// 风险情况
        /// </summary>
        public string CA { get; set; }

        /// <summary>
        /// 限额级别	0 绿灯 1黄灯 2橙灯 3红灯
        /// </summary>
        public string LE { get; set; }

        /// <summary>
        ///  交易编号
        /// </summary>
        public string SID { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        public string ME { get; set; }
    }
}