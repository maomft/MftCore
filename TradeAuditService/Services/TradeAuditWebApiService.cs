using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TradeAuditService;
using TradeAuditService.Helper;
using TradeAuditService.Models.MobileApproveTaskByNodeId_Batch;
using TradeAuditService.Models.MobileCheckBeforeActionByNodeId_Batch;
using TradeAuditService.Models.MobileGetTaskNodeGroup;
using TradeAuditService.Models.MobileGetTaskNodeLstByPage;
using TradeAuditService.Models.MobileSingleLimitresult;
using TradeAuditService.Models.MobileSingleTaskNodeTree;
using TradeAuditService.Models.MobileSingleTraceLog;
using TradeAuditService.Models.MobileSingleTradeDetailNew;
using TradeAuditService.Models.MobileSingleTradeTarget;
using TradeAuditService.WebApi.Login;

namespace TradeAuditWeb.WebApi
{
    public class TradeAuditWebApiService
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string LoginIn(LoginInInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileLogon);
        }

        /// <summary>
        /// 分页查询审批数据列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileGetTaskNodeLstByPage(MobileGetTaskNodeLstByPageInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileGetTaskNodeLstByPage);
        }

        /// <summary>
        /// 7.3查询单笔审批单审批流程图
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileSingleTaskNodeTree(MobileSingleTaskNodeTreeInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileSingleTaskNodeTree);

        }

        /// <summary>
        /// 7.4查询审批日志
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileSingleTraceLog(MobileSingleTraceLogInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileSingleTraceLog);
        }

        /// <summary>
        /// 7.5查询限额检查结果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileSingleLimitresult(MobileSingleLimitresultInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileSingleLimitresult);
        }

        /// <summary>
        /// 7.6查询交易指标
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileSingleTradeTarget(MobileSingleTradeTargetInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileSingleTradeTarget);
        }

        /// <summary>
        /// 7.7查询单笔交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileSingleTradeDetailNew(MobileSingleTradeDetailNewInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileSingleTradeDetailNew);
        }
        /// <summary>
        /// 7.8批量审批前检查
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileCheckBeforeActionByNodeId_Batch(MobileCheckBeforeActionByNodeId_BatchInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileCheckBeforeActionByNodeIdBatch);
        }

        /// <summary>
        /// 7.9批量审批操作
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileApproveTaskByNodeId_Batch(MobileApproveTaskByNodeId_BatchInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileApproveTaskByNodeIdBatch);
        }
        /// <summary>
        /// 7.10查询审批数据分组信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileGetTaskNodeGroup(MobileGetTaskNodeGroupInput input)
        {
            return GetResponseData(input, AuditWebApiMethodEnum.MobileGetTaskNodeGroup);
        }


        /// <summary>
        /// 拼接请求链接
        /// </summary>
        private string GetUrl(AuditWebApiMethodEnum methodEnum)
        {
            return Consts.TradeAuditRootUrl + methodEnum.GetDescription();
        }

        /// <summary>
        /// 获得请求数据
        /// </summary>
        private string GetResponseData(object paramters,AuditWebApiMethodEnum methodEnum )
        {
            using (var client = new HttpClient())
            {
                string url = GetUrl(methodEnum);

                using (HttpContent content = new StringContent(JsonConvert.SerializeObject(paramters)))
                {
                    var response = client.PostAsync(url, content).Result;

                    return response.Content.ReadAsStringAsync().Result;
                }

            }
        }
    }
}
