using System.Collections.Generic;

namespace TradeAuditService.Models.WebApiResult.MobileGetTaskNodeGroup
{
    /// <summary>
    /// 7.10查询审批数据分组信息
    /// </summary>
    public class MobileGetTaskNodeGroupRT : RT
    {
        public List<G> G { get; set; }
    }

    public class G
    {
        /// <summary>
        ///  组合编号
        /// </summary>
        public string C { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string MyProperty { get; set; }

        /// <summary>
        /// 组合名称
        /// </summary>
        public string N { get; set; }

        /// <summary>
        /// 项目编号
        /// </summary>
        public string P { get; set; }

        /// <summary>
        /// 组合里面的数量
        /// </summary>
        public int CT { get; set; }
    }
}