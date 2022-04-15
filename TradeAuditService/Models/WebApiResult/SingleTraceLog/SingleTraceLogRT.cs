using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult.SingleTraceLog
{
    /// <summary>
    /// 7.4查询审批日志
    /// </summary>
    public class SingleTraceLogRT:RT
    {
        public List<TraceLog> TL { get; set; }
    }

    public class TraceLog
    {
        /// <summary>
        /// 
        /// </summary>
        public string TI { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string LY { get; set; }

        /// <summary>
        /// 名义审批人
        /// </summary>
        public string NA { get; set; }

        /// <summary>
        /// 实际审批人
        /// </summary>
        public string ON { get; set; }

        /// <summary>
        /// 审批角色
        /// </summary>
        public string RN { get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public string AN { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? OT { get; set; }


        public string OE { get; set; }

    }
}
