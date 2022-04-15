using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult.MobileSingleTaskNodeTree
{
    public class SingleTaskNodeTreeRT:RT
    {
        public object T { get; set; }
    }
    public class T
    {
        /// <summary>
        /// 审批流程
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 流程名称，步骤名称，角色名称
        /// </summary>
        public string TX { get; set; }

        /// <summary>
        /// 流程编号，步骤编号，角色编号该处不用显示和处理
        /// </summary>
        public string VA { get; set; }

        /// <summary>
        /// 该处不用显示和处理
        /// </summary>
        public string IN { get; set; }

        /// <summary>
        /// ROOT 根节点,STEP 步骤节点,ROLE 角色节点
        /// </summary>
        public string TY { get; set; }

        /// <summary>
        /// 节点图标显示类型,待审批、审批通过、拒绝显示图标不一样
        /// </summary>
        public string LE { get; set; }

        [JsonProperty("T")]
        public List<T> TClidren { get; set; }
    }
}
