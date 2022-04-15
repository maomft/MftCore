namespace TradeAuditService.Models.MobileSingleTradeDetailNew
{
    /// <summary>
    /// 7.7查询单笔交易详情
    /// </summary>
    public class MobileSingleTradeDetailNewInput
    {
        /// <summary>
        /// 登录用户代码
        /// </summary>
        public string aUserCode { get; set; }

        /// <summary>
        ///  交易编号	7.3方法中返回的ID编号
        /// </summary>
        public string aSysOrdId { get; set; }
    }
}