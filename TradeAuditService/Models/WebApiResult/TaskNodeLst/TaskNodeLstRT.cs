
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult.TaskNodeLst
{
    /// <summary>
    /// 审批数据列表的RT模型
    /// </summary>
    public class TaskNodeLstRT:RT
    {
        public List<TaskNode> ROW { get; set; }
    }

    /// <summary>
    /// 审核数据
    /// </summary>
    public class TaskNode
    {


        /// <summary>
        /// 审批编号
        /// </summary>
        public string TID { get; set; }

        /// <summary>
        /// 审批节点编号
        /// </summary>
        public string NID { get; set; }

        /// <summary>
        /// 审批角色编号，审批用户
        /// </summary>
        public string GR { get; set; }

        /// <summary>
        /// 交易编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 是否会签角色
        /// </summary>
        public string ISCCROLE { get; set; }

        /// <summary>
        /// 交易方向
        /// </summary>
        public string TY { get; set; }

        /// <summary>
        /// 忽略
        /// </summary>
        public string CASHDIRECTION { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        public string OR { get; set; }

        /// <summary>
        /// 交易信息，交易方向、类型不同，返回的Name的数量和名称是不同的
        /// </summary>
        public List<TaskNodeColumn> R {get;set;}
    }

    public class TaskNodeColumn
    {
        public string NAME { get; set; }


        [JsonProperty("#text")]
        public string text { get; set; }
    }
}
